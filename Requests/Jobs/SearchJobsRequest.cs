using System;
using System.Collections.Generic;
using System.Text;
using Modsi.QueryAttribute;

namespace UpWork.NET.Requests.Jobs
{
    public class SearchJobsRequest
    {
        [QueryAttribute("q", true, "")]
        public string Q { get; set; }

        [QueryAttribute("title", true, "")]
        public string Title { get; set; }

        [QueryAttribute("skills", true, "")]
        public string Skills { get; set; }

        [QueryAttribute("category2", true, "")]
        public string Category { get; set; }

        [QueryAttribute("subcategory2", true, "")]
        public string Subcategory { get; set; }

        [QueryAttribute("job_type", true, "")]
        public string JobType { get; set; }

        [QueryAttribute("duration", true, "")]
        public string Duration { get; set; }

        [QueryAttribute("workload", true, "")]
        public string Workload { get; set; }

        [QueryAttribute("client_feedback", true, "")]
        public string ClientFeedback { get; set; }

        [QueryAttribute("client_hires", true, "")]
        public string ClientHires { get; set; }

        [QueryAttribute("budget", true, "")]
        public string Budget { get; set; }

        [QueryAttribute("job_status", true, "")]
        public string JobStatus { get; set; }

        [QueryAttribute("days_posted", true, "0")]
        public int DaysPosted { get; set; }

        [QueryAttribute("paging", true, "")]
        public string Paging { get; set; }

        [QueryAttribute("sort", true, "")]
        public string Sort { get; set; }
    }
}
