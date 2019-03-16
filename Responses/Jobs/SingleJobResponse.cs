using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace UpWork.NET.Responses.Jobs
{
    public partial class SingleJobResponse
    {
        [JsonProperty("server_time")]
        
        public long ServerTime { get; set; }

        [JsonProperty("auth_user")]
        public AuthUser AuthUser { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }
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

    public partial class Profile
    {
        [JsonProperty("op_additional_questions")]
        public string OpAdditionalQuestions { get; set; }

        [JsonProperty("ui_opening_status")]
        public string UiOpeningStatus { get; set; }

        [JsonProperty("op_pref_hourly_rate_min")]
        public string OpPrefHourlyRateMin { get; set; }

        [JsonProperty("job_type")]
        public string JobType { get; set; }

        [JsonProperty("op_pref_location")]
        public string OpPrefLocation { get; set; }

        [JsonProperty("ciphertext")]
        public string Ciphertext { get; set; }

        [JsonProperty("op_low_hourly_rate_all")]
        
        public long OpLowHourlyRateAll { get; set; }

        [JsonProperty("job_category_level_two")]
        public string JobCategoryLevelTwo { get; set; }

        [JsonProperty("op_pref_odesk_hours")]
        
        public long OpPrefOdeskHours { get; set; }

        [JsonProperty("op_ctime")]
        public string OpCtime { get; set; }

        [JsonProperty("op_engagement")]
        public string OpEngagement { get; set; }

        [JsonProperty("op_pref_english_skill")]
        
        public long OpPrefEnglishSkill { get; set; }

        [JsonProperty("op_tot_feedback")]
        
        public long OpTotFeedback { get; set; }

        [JsonProperty("op_description")]
        public string OpDescription { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("op_title")]
        public string OpTitle { get; set; }

        [JsonProperty("op_other_jobs")]
        public string OpOtherJobs { get; set; }

        [JsonProperty("job_category_level_one")]
        public string JobCategoryLevelOne { get; set; }

        [JsonProperty("op_pref_hourly_rate_max")]
        public string OpPrefHourlyRateMax { get; set; }

        [JsonProperty("op_required_skills")]
        public OpRequiredSkills OpRequiredSkills { get; set; }

        [JsonProperty("op_contractor_tier")]
        
        public long OpContractorTier { get; set; }

        [JsonProperty("assignment_info")]
        public AssignmentInfo AssignmentInfo { get; set; }

        [JsonProperty("op_pref_fb_score")]
        public string OpPrefFbScore { get; set; }

        [JsonProperty("assignments")]
        public string Assignments { get; set; }

        [JsonProperty("buyer")]
        public Buyer Buyer { get; set; }

        [JsonProperty("op_is_cover_letter_required")]
        
        public long OpIsCoverLetterRequired { get; set; }

        [JsonProperty("op_job_category_v2")]
        public OpJobCategoryV2 OpJobCategoryV2 { get; set; }

        [JsonProperty("op_pref_has_portfolio")]
        
        public long OpPrefHasPortfolio { get; set; }

        [JsonProperty("op_cny_upm_verified")]
        
        public long OpCnyUpmVerified { get; set; }

        [JsonProperty("engagement_weeks")]
        public string EngagementWeeks { get; set; }

        [JsonProperty("op_high_hourly_rate_all")]
        
        public long OpHighHourlyRateAll { get; set; }

        [JsonProperty("op_attached_doc")]
        public string OpAttachedDoc { get; set; }

        [JsonProperty("candidates")]
        public string Candidates { get; set; }

        [JsonProperty("op_tot_intv")]
        
        public long OpTotIntv { get; set; }

        [JsonProperty("op_tot_cand")]
        
        public long OpTotCand { get; set; }
    }

    public partial class Buyer
    {
        [JsonProperty("op_tot_fp_asgs")]
        
        public long OpTotFpAsgs { get; set; }

        [JsonProperty("op_tot_hours")]
        
        public long OpTotHours { get; set; }

        [JsonProperty("op_tot_jobs_posted")]
        public long OpTotJobsPosted { get; set; }

        [JsonProperty("op_adjusted_score")]
        
        public long OpAdjustedScore { get; set; }

        [JsonProperty("op_timezone")]
        public string OpTimezone { get; set; }

        [JsonProperty("op_country")]
        public string OpCountry { get; set; }

        [JsonProperty("op_tot_jobs_filled")]
        
        public long OpTotJobsFilled { get; set; }

        [JsonProperty("op_tot_asgs")]
        
        public long OpTotAsgs { get; set; }

        [JsonProperty("op_tot_jobs_open")]
        public long OpTotJobsOpen { get; set; }

        [JsonProperty("op_tot_charge")]
        public long OpTotCharge { get; set; }

        [JsonProperty("op_contract_date")]
        public string OpContractDate { get; set; }
    }

    public partial class OpJobCategoryV2
    {
        [JsonProperty("op_job_category_v")]
        public OpJobCategoryV OpJobCategoryV { get; set; }
    }

    public partial class OpJobCategoryV
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("groups")]
        public Groups Groups { get; set; }
    }

    public partial class Groups
    {
        [JsonProperty("group")]
        public Group Group { get; set; }
    }

    public partial class Group
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public partial class OpRequiredSkills
    {
        [JsonProperty("op_required_skill")]
        public List<OpRequiredSkill> OpRequiredSkill { get; set; }
    }

    public partial class OpRequiredSkill
    {
        [JsonProperty("skill")]
        public string Skill { get; set; }
    }
}
