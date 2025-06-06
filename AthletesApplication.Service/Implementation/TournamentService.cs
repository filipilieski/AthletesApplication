using AthletesApplication.Domain.DomainModels;
using AthletesApplication.Repository.Interface;
using AthletesApplication.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace AthletesApplication.Service.Implementation
{
    public class TournamentService : ITournamentService
    {
        private readonly IRepository<Tournament> _tournamentRepository;
        private readonly IRepository<AthleteInTournament> _athleteInTournamentRepository;
        private readonly IParticipationService _participationService;

        public TournamentService(IRepository<Tournament> tournamentRepository, IRepository<AthleteInTournament> athleteInTournamentRepository, IParticipationService participationService)
        {
            _tournamentRepository = tournamentRepository;
            _athleteInTournamentRepository = athleteInTournamentRepository;
            _participationService = participationService;
        }

        public Tournament CreateTournament(string userId)
        {
            var participations = _participationService.GetAllByCurrentUser(userId);

            if (participations == null || participations.Count == 0)
            {
                throw new InvalidOperationException("User has no participations.");
            }

            var tournament = new Tournament
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                UserId = userId
            };

            _tournamentRepository.Insert(tournament);

            var addedAthletes = new HashSet<Guid>();

            foreach (var participation in participations)
            {
                if (!addedAthletes.Contains(participation.AthleteId))
                {
                    var ait = new AthleteInTournament
                    {
                        Id = Guid.NewGuid(),
                        AthleteId = participation.AthleteId,
                        TournamentId = tournament.Id
                    };

                    _athleteInTournamentRepository.Insert(ait);
                    addedAthletes.Add(participation.AthleteId);
                }

                _participationService.DeleteById(participation.Id);
            }

            return tournament;
        }

        public Tournament GetTournamentDetails(Guid id)
        {
            return _tournamentRepository.Get(
                selector: x => x,
                predicate: x => x.Id == id,
                include: x => x.Include(t => t.Athletes).ThenInclude(ait => ait.Athlete)
            );
        }

    }
}
