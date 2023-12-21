namespace ProfileService.Model
{
    public class AchievementComment
    {
        public string achievementCommentID { get; set; }
        public string content { get; set; }
        public string timestamp { get; set; }
        public string achievementID { get; set; }
        public string profileID { get; set; }
    }

    public class AchievementCommentCollection
    {
        public List<AchievementComment> AchievementComment { get; set; }

        public List<AchievementComment> GetAchievementComments()
        {
            return new List<AchievementComment>
            {
                new AchievementComment()
                {
                    achievementCommentID = "1",
                    content = "Reached the summit with an amazing view!",
                    timestamp = "2023-01-20 14:35:00",
                    achievementID = "1",
                    profileID = "1"
                },
                new AchievementComment()
                {
                    achievementCommentID = "2",
                    content = "Explored deep into the forest, found rare species!",
                    timestamp = "2023-02-10 18:50:00",
                    achievementID = "2",
                    profileID = "2"
                }
            };
        }
    }
}
