using TrailApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.AspNetCore.Mvc;
using ProfileService.Model;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddDbContext<UserDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Trail App",
        Version = "v1"
    });
});

var app = builder.Build();
app.UseSwaggerUI();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
        SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DataSeeder>();
        service.Seed();
    }
}



app.UseSwagger(x => x.SerializeAsV2 = true);


//User
app.MapGet("/user/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetUserById(id);
});

app.MapGet("/users", ([FromServices] IDataRepository db) =>
{
    return db.GetUsers();
});

app.MapPut("/user/{id}", ([FromServices] IDataRepository db, User user) =>
{
    return db.PutUser(user);
});


app.MapPost("/user", ([FromServices] IDataRepository db, User user) =>
{
    return db.AddUser(user);
});


//Profile
app.MapGet("/profile/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetProfileById(id);
});

app.MapGet("/profiles", ([FromServices] IDataRepository db) =>
{
    return db.GetProfiles();
});

app.MapPut("/profile/{id}", ([FromServices] IDataRepository db, Profile profile) =>
{
    return db.PutProfile(profile);
});


app.MapPost("/profile", ([FromServices] IDataRepository db, Profile profile) =>
{
    return db.AddProfile(profile);
});


//Trail
app.MapGet("/trail/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetTrailById(id);
});

app.MapGet("/trails", ([FromServices] IDataRepository db) =>
{
    return db.GetTrails();
});

app.MapPut("/trail/{id}", ([FromServices] IDataRepository db, Trail trail) =>
{
    return db.PutTrail(trail);
});


app.MapPost("/trail", ([FromServices] IDataRepository db, Trail trail) =>
{
    return db.AddTrail(trail);
});


//Trail
app.MapGet("/activity/{id}", ([FromServices] IDataRepository db, string id) =>
{
    return db.GetActivityById(id);
});

app.MapGet("/activities", ([FromServices] IDataRepository db) =>
{
    return db.GetActivities();
});

app.MapPut("/activity/{id}", ([FromServices] IDataRepository db, Activity activity) =>
{
    return db.PutActivity(activity);
});


app.MapPost("/activity", ([FromServices] IDataRepository db, Activity activity) =>
{
    return db.AddActivity(activity);
});

app.Run();
