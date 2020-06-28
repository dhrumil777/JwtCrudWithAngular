using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using WebAPP.Models;
using WebAPP.Service;

namespace WebAPP.Controllers
{
   //Nuget Details
    //System.IdentityModel.Token.JWT

  //For validation the Token
   //Microsoft.Owin.Security.JWT => 10 MB
   //Microsoft.AspNet.WebApi.Owin => 19.2MB
   //Microsoft.Owin.Host.SystemWeb => 37.5MB

  //Postman call deatils 
   //Key:Authorization Value:Bearer Paste Token
   //Content-Type application/json

    public class AuthController : ApiController
    {
        AuthService authService;
        public AuthController()
        {
            authService = new AuthService();
        }

        [HttpGet]
        public HttpResponseMessage TestData()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "It's working");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        public HttpResponseMessage Login(LoginUserVM User)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, authService.LoginService(User));
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,ex);
            }
        }

        [Authorize]
        [HttpPost]
        public HttpResponseMessage ValidateToken()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Token validate successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}
