using ProfileService.IService;

namespace ProfileService.Service
{
    public class UserService : IUserService
    {
        public bool CheckUser(string email, string password)
        {
            return email.Equals("grace@plymouth.ac.uk") && password.Equals("ISAD123!");
        }
    }
}
