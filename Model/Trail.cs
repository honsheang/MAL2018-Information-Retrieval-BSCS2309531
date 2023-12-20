namespace ProfileService.Model
{
    public class Trail
    {
        public string trailID { get; set; }
        public string trailName { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public string creationDate { get; set; }
    }

    public class TrailCollection
    {
        public List<Trail> trail { get; set; }

        public List<Trail> GetTrails()
        {
            return new List<Trail>
            {
                new Trail()
                {
                    trailID = "1",
                    trailName = "Mountain Trail",
                    location = "Penang Hill",
                    description = "A challenging trail with breathtaking views.",
                    creationDate = "2023-01-10 12:30:00"
                },
                new Trail()
                {
                    trailID = "2",
                    trailName = "Forest Trail",
                    location = "Amazon Rainforest",
                    description = "An adventurous trail through the dense forest.",
                    creationDate = "2023-02-05 15:45:00"
                },
                new Trail()
                {
                    trailID = "3",
                    trailName = "Seaside Trail",
                    location = "Indian River Shores",
                    description = "Nice trail with magnificent view.",
                    creationDate = "2023-02-21 15:45:00"
                }
            };
        }
    }
}
