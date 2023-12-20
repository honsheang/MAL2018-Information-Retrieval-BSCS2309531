using TrailApp.Model;

namespace ProfileService.Model
{
    public class Profile
    {
        public string profileID { get; set; }
        public string profileName { get; set; }
        public string description { get; set; }
        public string creationDate { get; set; }
        public string role { get; set; }
    }

    public class ProfileCollection
    {
        public List<Profile> profile { get; set; }

        public List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
                new Profile()
                {
                    profileID = "1",
                    profileName = "graceHop",
                    description = "Enthusiastic hiker",
                    creationDate = "2023-01-15 09:00:00",
                    role = "Admin"
                },
                new Profile()
                {
                    profileID = "2",
                    profileName = "TBL",
                    description = "Nature lover",
                    creationDate = "2023-02-01 10:30:00",
                    role = "User"
                },
                new Profile()
                {
                    profileID = "3",
                    profileName = "Ada",
                    description = "Sea lover",
                    creationDate = "2023-04-13 11:10:00",
                    role = "User"
                }
            };
        }
    }
}
