namespace ProfileService.Model
{
    public class Activity
    {
        public string activityID { get; set; }
        public string activityName { get; set; }
        public string units { get; set; }
        public string activityTimePreference { get; set; }
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
                    activityTimePreference = "Morning"
                },
                new Activity()
                {
                    activityID = "2",
                    activityName = "Running",
                    units = "Kilometers",
                    activityTimePreference = "Evening"
                },
                new Activity()
                {
                    activityID = "3",
                    activityName = "Running",
                    units = "Kilometers",
                    activityTimePreference = "Evening"
                }
            };
        }
    }
}
