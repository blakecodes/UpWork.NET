using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace UpWork.NET.Responses.Jobs
{
    public partial class JobProfileResponse
    {
        [JsonProperty("server_time")]
        
        public long ServerTime { get; set; }

        [JsonProperty("auth_user")]
        public AuthUser AuthUser { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }
    }

    public partial class AssignmentInfo
    {
        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("ciphertext_developer_recno")]
        public string CiphertextDeveloperRecno { get; set; }

        [JsonProperty("tot_hours")]
        
        public long TotHours { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_data")]
        public string EndData { get; set; }

        [JsonProperty("total_charge")]
        
        public long TotalCharge { get; set; }
    }

    public partial class Assignments
    {
        [JsonProperty("assignment")]
        public Assignment[] Assignment { get; set; }
    }

    public partial class Assignment
    {
        [JsonProperty("as_total_hours")]
        public string AsTotalHours { get; set; }

        [JsonProperty("as_ciphertext")]
        public string AsCiphertext { get; set; }

        [JsonProperty("as_rate")]
        public string AsRate { get; set; }

        [JsonProperty("as_from")]
        public string AsFrom { get; set; }

        [JsonProperty("as_engagement_title")]
        public string AsEngagementTitle { get; set; }

        [JsonProperty("as_status")]
        public object AsStatus { get; set; }

        [JsonProperty("as_opening_title")]
        public string AsOpeningTitle { get; set; }

        [JsonProperty("as_to")]
        public string AsTo { get; set; }

        [JsonProperty("as_job_type")]
        public object AsJobType { get; set; }

        [JsonProperty("as_total_charge")]
        public string AsTotalCharge { get; set; }

        [JsonProperty("as_ciphertext_opening_recno")]
        public string AsCiphertextOpeningRecno { get; set; }

        [JsonProperty("feedback", NullValueHandling = NullValueHandling.Ignore)]
        public Feedback Feedback { get; set; }
    }

    public partial class Feedback
    {
        [JsonProperty("response_for_freelancer_feedback")]
        public string ResponseForFreelancerFeedback { get; set; }

        [JsonProperty("feedback_suppressed")]
        
        public long FeedbackSuppressed { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("scores")]
        public Scores Scores { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("comment_is_public")]
        
        public long CommentIsPublic { get; set; }
    }

    public partial class Scores
    {
        [JsonProperty("score")]
        public Score[] Score { get; set; }
    }

    public partial class Score
    {
        [JsonProperty("label")]
        public object Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("score")]
        
        public long ScoreScore { get; set; }
    }

    public partial class Buyer
    {
        [JsonProperty("op_city")]
        public string OpCity { get; set; }

        [JsonProperty("op_state")]
        public string OpState { get; set; }
    }

    public partial class Candidates
    {
        [JsonProperty("candidate")]
        public Candidate[] Candidate { get; set; }
    }

    public partial class Candidate
    {
        [JsonProperty("create_date_ts")]
        
        public long CreateDateTs { get; set; }

        [JsonProperty("ciphertext")]
        public string Ciphertext { get; set; }
    }
}
