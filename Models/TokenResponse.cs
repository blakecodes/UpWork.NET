using System;
using System.Collections.Generic;
using System.Text;
using TinyOAuth1;

namespace UpWork.NET.Models
{
    public class TokenResponse
    {
        public RequestTokenInfo RequestToken { get; set; }
        public string AuthorizationUrl { get; set; }
    }
}
