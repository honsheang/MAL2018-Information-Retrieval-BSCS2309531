namespace TrailApp.Model
{
    public class DataSeeder
    {
        private readonly UserDbContext userDbContext;
        public DataSeeder(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        public void Seed()
        {
            if(!userDbContext.User.Any())
            {
                var user = new List<User>()
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
                        password = "abc1234"
                    }
                };

                userDbContext.User.AddRange(user);
                userDbContext.SaveChanges();
            }
        }
    }
}
