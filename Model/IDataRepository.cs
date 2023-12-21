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

        //Achievement
        List<Achievement> AddAchievement(Achievement achievement);
        List<Achievement> GetAchievements();
        Achievement PutAchievement(Achievement achievement);
        Achievement GetAchievementById(string Id);

        //AchievementComment
        List<AchievementComment> AddAchievementComment(AchievementComment achievementComment);
        List<AchievementComment> GetAchievementComments();
        AchievementComment PutAchievementComment(AchievementComment achievementComment);
        AchievementComment GetAchievementCommentById(string Id);


        //EmergencyContact
        List<EmergencyContact> AddEmergencyContact(EmergencyContact EmergencyContact);
        List<EmergencyContact> GetEmergencyContacts();
        EmergencyContact PutEmergencyContact(EmergencyContact EmergencyContact);
        EmergencyContact GetEmergencyContactById(string Id);
    }
}