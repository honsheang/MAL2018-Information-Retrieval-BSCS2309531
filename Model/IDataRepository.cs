using System.Collections.Generic;
namespace TrailApp.Model
{
    public interface IDataRepository
    {
        List<User> AddUser(User user);
        List<User> GetUsers();
        User PutUser(User user);
        User GetUserById(string Id);
    }
}