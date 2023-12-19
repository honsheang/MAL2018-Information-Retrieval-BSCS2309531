using TrailApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.AspNetCore.Mvc;

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

app.Run();
