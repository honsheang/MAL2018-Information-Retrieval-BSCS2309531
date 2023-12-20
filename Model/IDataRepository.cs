using ProfileService.Model;
using System.Collections.Generic;
namespace TrailApp.Model
{
    public interface IDataRepository
    {
        //User
        List<User> AddUser(User user);
        List<User> GetUsers();
        User PutUser(User user);
        User GetUserById(string Id);

        //Profile
        List<Profile> AddProfile(Profile profile);
        List<Profile> GetProfiles();
        Profile PutProfile(Profile profile);
        Profile GetProfileById(string Id);

        //Trail
        List<Trail> AddTrail(Trail trail);
        List<Trail> GetTrails();
        Trail PutTrail(Trail trail);
        Trail GetTrailById(string Id);

        //Activity
        List<Activity> AddActivity(Activity activity);
        List<Activity> GetActivities();
        Activity PutActivity(Activity activity);
        Activity GetActivityById(string Id);
    }
}