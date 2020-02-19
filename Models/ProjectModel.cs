using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REIDAccess.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public ProjectType Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        [DataType(DataType.Date)]
        public DateTime BeginDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public StatusType Status { get; set; }
        public IEnumerable<ProjectTaskModel> Tasks { get; set; }
    }

    public enum ProjectType
    {
        [Display(Name = "This is an Idea")] Idea,
        [Display(Name = "This is a learning opportunity")] Learning,
        [Display(Name = "This is a social activity")] Social,
        [Display(Name = "This is a skill training")] Skill,
        [Display(Name = "This is for Best Buddy")] Buddy,
        [Display(Name = "This is for Special Olympics")] Olympics,
        [Display(Name = "This is for Sunshine Social Club")]Sunshine,
        [Display(Name = "This is for another organization")] Other

    }

    public enum StatusType
    {
        [Display(Name = "Idea Queue")] Idea,
        [Display(Name = "Initiation")] Initiate,
        [Display(Name = "Planning")] Plan,
        [Display(Name = "Execution")] Execute,
        [Display(Name = "Closure")] Close,
        [Display(Name = "Not enough interest")] NoInterest,
        [Display(Name = "Interested but need sponsorship")] NoSponsorship
    }
}