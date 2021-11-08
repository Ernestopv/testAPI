using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using testAPI.Models;

namespace testAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {


        [HttpGet("token")]
        public IActionResult GetToken()
        {
            var unixTime = ((DateTimeOffset)DateTime.UtcNow.AddDays(1)).ToUnixTimeSeconds();

            var roles = new List<string>() { "admin", "single", "yahoo", "BlablablaRights" };
            var accessToken = new AccessToken()
            {
                aud = "http://ernesto.com",
                iss = "https://krakend.io",
                sub = "1234567890qwertyuio",
                jti = "mnb23vcsrt756yuiomnbvcx98ertyuiop",
                roles = roles,
                exp = unixTime
            };



            var refreshToken = new RefreshToken()
            {
                aud = "http://ernesto.com",
                iss = "https://krakend.io",
                sub = "1234567890qwertyuio",
                jti = "mnb23vcsrt756yuiomnbvcx98ertyuiop",
                exp = unixTime
            };


            var response = new Response()
            {
               
                access_token = accessToken,
                refresh_token = refreshToken,
                exp = unixTime
            };


            return Ok(response);
        }
    }
}
