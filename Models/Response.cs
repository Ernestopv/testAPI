using System;
using System.Collections.Generic;

namespace testAPI.Models
{
    public class Response
    {
        public AccessToken access_token { get; set; }

        public RefreshToken refresh_token { get; set; }

        public long exp { get; set; }
    }


    public class AccessToken
    {
        public string aud { get; set; }
        public string iss { get; set; }
        public string sub { get; set; }
        public string jti { get; set; }
        public List<string> roles { get; set; }

        public  long  exp { get; set; }

    }


    public class RefreshToken
    {
        public string aud { get; set; }
        public string iss { get; set; }
        public string sub { get; set; }
        public string jti { get; set; }

        public long exp { get; set; }

    }
}
