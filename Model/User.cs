namespace TrailApp.Model
{
    public class User
    {
        public string userID {  get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public string archivedAccess { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string dateOfBirth { get; set; }
    }

    public class UserCollection
    {
        public List<User> user { get; set; }

        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User()
                {
                    userID = "1",
                    username = "Grace Hopper",
                    email = "grace@plymouth.ac.uk",
                    password = "ISAD123!",
                    gender = "Female",
                    archivedAccess = "1",
                    height = "167.0",
                    weight = "53.6",
                    dateOfBirth = "1995-05-15"
                },
                new User()
                {
                    userID = "2",
                    username = "Tim Berners-Lee",
                    email = "tim@plymouth.ac.uk",
                    password = "COMP2001!",
                    gender = "Male",
                    archivedAccess = "0",
                    height = "181.0",
                    weight = "66.8",
                    dateOfBirth = "1999-08-22"
                },
                new User()
                {
                    userID = "3",
                    username = "Ada Lovelace",
                    email = "ada@plymouth.ac.uk",
                    password = "abc123",
                    gender = "Female",
                    archivedAccess = "0",
                    height = "161.5",
                    weight = "56.3",
                    dateOfBirth = "1999-03-21"
                }
            };
        }
    }
}
