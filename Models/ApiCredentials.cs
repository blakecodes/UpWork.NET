using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UpWork.NET.Models
{
    public class ApiCredentials
    {
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string CallbackUrl { get; set; }
    }
}
