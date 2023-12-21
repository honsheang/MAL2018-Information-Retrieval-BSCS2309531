using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProfileService.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TrailApp.Model;

namespace ProfileService.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        List<User> _users = new List<User>();

        //public UserController() 
        //{
        //    _users = new List<User>();
        //    for(int i = 1; i <= 9; i++)
        //    {
        //        _users.Add(new User()
        //        {
        //            userID = i,
        //            Name = "Usr" + i,
        //            Roll = "100" + i
        //        });
        //    }
        //}
        // GET: api/users
        public IEnumerable<User> Get()
        {
            return _users;
        }

        [HttpPost, Route("login")]
        public IActionResult Login(Login login)
        {
            try
            {
                if (string.IsNullOrEmpty(login.email) ||
                string.IsNullOrEmpty(login.password))
                    return BadRequest("Username and/or Password not specified");
                if (login.email.Equals("grace@plymouth.ac.uk") && login.password.Equals("ISAD123!"))
                {
                    var secretKey = new SymmetricSecurityKey
                    (Encoding.UTF8.GetBytes("thisisasecretkey@123"));
                    var signinCredentials = new SigningCredentials
                    (secretKey, SecurityAlgorithms.HmacSha256);
                    var jwtSecurityToken = new JwtSecurityToken(
                        issuer: "ABCXYZ",
                        audience: "http://localhost:51398",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: signinCredentials
                    );
                    Ok(new JwtSecurityTokenHandler().
                    WriteToken(jwtSecurityToken));
                }
            }
            catch
            {
                return BadRequest
                ("An error occurred in generating the token");
            }
            return Unauthorized();
        }
    }
}
