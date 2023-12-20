using ProfileService.Model;

namespace TrailApp.Model
{
    public class DataRepository : IDataRepository
    {
        private readonly UserDbContext db;
        public DataRepository(UserDbContext db)
        {
            this.db = db;
        }

        //User//
        public List<User> GetUsers() => db.User.ToList();

        public User PutUser(User user)
        {
            db.User.Update(user);
            db.SaveChanges();
            return db.User.Where(x => x.userID == user.userID).FirstOrDefault();
        }

        public List<User> AddUser(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
            return db.User.ToList();
        }

        public User GetUserById (string Id)
        {
            return db.User.Where(x => x.userID == Id).FirstOrDefault();
        }


        //Profile//
        public List<Profile> GetProfiles() => db.Profile.ToList();

        public Profile PutUProfile(Profile profile)
        {
            db.Profile.Update(profile);
            db.SaveChanges();
            return db.Profile.Where(x => x.profileID == profile.profileID).FirstOrDefault();
        }

        public List<Profile> AddProfile(Profile profile)
        {
            db.Profile.Add(profile);
            db.SaveChanges();
            return db.Profile.ToList();
        }

        public Profile GetProfileById(string Id)
        {
            return db.Profile.Where(x => x.profileID == Id).FirstOrDefault();
        }

        public Profile PutProfile(Profile profile)
        {
            throw new NotImplementedException();
        }

        //Trail//
        public List<Trail> GetTrails() => db.Trail.ToList();

        public Trail PutTrail(Trail trail)
        {
            db.Trail.Update(trail);
            db.SaveChanges();
            return db.Trail.Where(x => x.trailID == trail.trailID).FirstOrDefault();
        }

        public List<Trail> AddTrail(Trail trail)
        {
            db.Trail.Add(trail);
            db.SaveChanges();
            return db.Trail.ToList();
        }

        public Trail GetTrailrById(string Id)
        {
            return db.Trail.Where(x => x.trailID == Id).FirstOrDefault();
        }

        public Trail GetTrailById(string Id)
        {
            throw new NotImplementedException();
        }


        //Activity//
        public List<Activity> GetActivities() => db.Activity.ToList();

        public Activity PutActivity(Activity activity)
        {
            db.Activity.Update(activity);
            db.SaveChanges();
            return db.Activity.Where(x => x.activityID == activity.activityID).FirstOrDefault();
        }

        public List<Activity> AddActivity(Activity activity)
        {
            db.Activity.Add(activity);
            db.SaveChanges();
            return db.Activity.ToList();
        }

        public Activity GetActivityById(string Id)
        {
            return db.Activity.Where(x => x.activityID == Id).FirstOrDefault();
        }

        public List<Activity> AddActivity(Trail activity)
        {
            throw new NotImplementedException();
        }

        
    }
}
