namespace ProfileService.IService
{
    public interface IUserService
    {
        bool CheckUser(string email, string password);
    }
}
