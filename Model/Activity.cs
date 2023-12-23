namespace ProfileService.Model
{
    public class Activity
    {
        public string activityID { get; set; }
        public string activityName { get; set; }
        public string units { get; set; }
        public string activityTimePreference { get; set; }
        public string profileID { get; set; }
        public string trailID { get; set; }
    }

    public class ActivityCollection
    {
        public List<Activity> activity { get; set; }

        public List<Activity> GetActivities()
        {
            return new List<Activity>
            {
                new Activity()
                {
                    activityID = "1",
                    activityName = "Hiking",
                    units = "Miles",
                    activityTimePreference = "Morning",
                    profileID = "1",
                    trailID = "1"
                },
                new Activity()
                {
                    activityID = "2",
                    activityName = "Running",
                    units = "Kilometers",
                    activityTimePreference = "Evening",
                    profileID = "2",
                    trailID = "2"
                },
                new Activity()
                {
                    activityID = "3",
                    activityName = "Running",
                    units = "Kilometers",
                    activityTimePreference = "Evening",
                    profileID = "3",
                    trailID = "2"
                }
            };
        }
    }
}
