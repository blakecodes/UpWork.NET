using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace UpWork.NET.Responses.Jobs
{
    public partial class SearchJobsResponse
    {
        [JsonProperty("server_time")]
        public long ServerTime { get; set; }

        [JsonProperty("auth_user")]
        public AuthUser AuthUser { get; set; }

        [JsonProperty("jobs")]
        public Job[] Jobs { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public partial class Job
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("category2")]
        public object Category2 { get; set; }

        [JsonProperty("subcategory2")]
        public string Subcategory2 { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("job_type")]
        public object JobType { get; set; }

        [JsonProperty("budget")]
        public long Budget { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("workload")]
        public string Workload { get; set; }

        [JsonProperty("job_status")]
        public object JobStatus { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }
    }

    public partial class Client
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("feedback")]
        public double Feedback { get; set; }

        [JsonProperty("reviews_count")]
        public long ReviewsCount { get; set; }

        [JsonProperty("jobs_posted")]
        public long JobsPosted { get; set; }

        [JsonProperty("past_hires")]
        public long PastHires { get; set; }

        [JsonProperty("payment_verification_status")]
        public string PaymentVerificationStatus { get; set; }
    }

    public partial class Paging
    {
        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

}
