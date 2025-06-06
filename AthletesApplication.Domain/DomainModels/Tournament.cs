namespace AthletesApplication.Domain.DomainModels
{
    public class Tournament : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<AthleteInTournament> Athletes { get; set; }
    }
}
