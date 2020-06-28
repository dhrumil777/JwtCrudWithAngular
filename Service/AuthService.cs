using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using WebAPP.Models;

namespace WebAPP.Service
{
    public class AuthService
    {
        public object LoginService(LoginUserVM User)
        {

            if (User.UserName == "dhrumil" && User.Password == "password")
            {
                return GetToken();
            }
            else
            {
                return "User Not Valid";
            }
        }

        public object GetToken()
        {
            string key = "my_secrect_key_12345";
            string issuer = "http://mysite.com/";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var ClaimsParams = new List<Claim>();
            ClaimsParams.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            ClaimsParams.Add(new Claim("valid", "1"));
            ClaimsParams.Add(new Claim("userid", "1"));
            ClaimsParams.Add(new Claim("name", "dhrumil"));

            var token = new JwtSecurityToken(issuer, issuer, ClaimsParams, expires: DateTime.Now.AddDays(1), signingCredentials: credentials);

            var Jwt_Token = new JwtSecurityTokenHandler().WriteToken(token);

            return new { data = Jwt_Token };

        }
    }
}