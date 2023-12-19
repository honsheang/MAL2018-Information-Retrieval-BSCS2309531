namespace TrailApp.Model
{
    public class User
    {
        public string userID {  get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
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
                    password = "ISAD123!"
                },
                new User()
                {
                    userID = "2",
                    username = "Tim Berners-Lee",
                    email = "tim@plymouth.ac.uk",
                    password = "COMP2001!"
                },
                new User()
                {
                    userID = "3",
                    username = "Ada Lovelace",
                    email = "ada@plymouth.ac.uk",
                    password = "abc123"
                }
            };
        }
    }
}
