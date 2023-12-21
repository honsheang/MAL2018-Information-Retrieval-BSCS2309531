namespace ProfileService.Model
{
    public class Achievement
    {
        public string achievementID { get; set; }
        public string achievementTitle { get; set; }
        public string medal { get; set; }
        public string achievedDate { get; set; }
    }

    public class AchievementCollection
    {
        public List<Achievement> achievement { get; set; }

        public List<Achievement> GetAchievements()
        {
            return new List<Achievement>
            {
                new Achievement()
                {
                    achievementID = "1",
                    achievementTitle = "Mountain Summit",
                    medal = "Gold",
                    achievedDate = "2023-01-20 14:30:00"
                },
                new Achievement()
                {
                    achievementID = "2",
                    achievementTitle = "Forest Exploration",
                    medal = "Silver",
                    achievedDate = "2023-02-10 18:45:00"
                },
                new Achievement()
                {
                    achievementID = "3",
                    achievementTitle = "Forest Exploration",
                    medal = "Bronze",
                    achievedDate = "2023-03-13 19:15:00"
                }
            };
        }
    }
}
