using AthletesApplication.Service.Implementation;
using AthletesApplication.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AthletesApplication.Web.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly ITournamentService _tournamentService;

        public TournamentsController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Create()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var tournament = _tournamentService.CreateTournament(userId);
            return RedirectToAction("Details", new { id = tournament.Id });
        }

        [Authorize]
        public IActionResult Details(Guid id)
        {
            var tournament = _tournamentService.GetTournamentDetails(id);
            if (tournament == null)
            {
                return NotFound();
            }
            return View(tournament);
        }

    }
}
