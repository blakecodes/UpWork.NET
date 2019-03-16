using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace UpWork.NET.Responses.API
{
    public partial class GetApiUserResponse
    {
        [JsonProperty("server_time")]
        public long ServerTime { get; set; }

        [JsonProperty("auth_user")]
        public AuthUser AuthUser { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public partial class AuthUser
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public long TimezoneOffset { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("company_url")]
        public string CompanyUrl { get; set; }

        [JsonProperty("portrait_50_img")]
        public Uri Portrait50_Img { get; set; }

        [JsonProperty("has_agency")]
        public long HasAgency { get; set; }

        [JsonProperty("ref")]
        public long Ref { get; set; }

        [JsonProperty("portrait_100_img")]
        public Uri Portrait100_Img { get; set; }

        [JsonProperty("portrait_32_img")]
        public Uri Portrait32_Img { get; set; }

        [JsonProperty("capacity")]
        public Capacity Capacity { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }
    }

    public partial class Capacity
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        [JsonProperty("affiliate_manager")]
        public string AffiliateManager { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

}
