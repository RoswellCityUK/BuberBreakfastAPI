namespace BuberBreakfastAPI.Models
{
    public class Breakfast
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime StartDateTime { get; }
        public DateTime EndDateTime { get; }
        public DateTime LastModifiedTime { get; }
        public List<string> Savory { get; }
        public List<string> Sweet { get; }

        public Breakfast(Guid id,
                         string name,
                         string description,
                         DateTime startDateTime,
                         DateTime endDateTime,
                         DateTime lastModifiedTime,
                         List<string> savoury,
                         List<string> sweet)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            LastModifiedTime = lastModifiedTime;
            Savory = savoury;
            Sweet = sweet;
        }
    }
}