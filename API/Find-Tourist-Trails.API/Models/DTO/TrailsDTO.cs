namespace Find_Tourist_Trails.Models.DTO
{
    public class TrailsDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string WalkImageUrl { get; set; }
        public string Difficulty { get; set; }
        public string Region { get; set; }
        public string MapLink { get; set; } 
    }
}
