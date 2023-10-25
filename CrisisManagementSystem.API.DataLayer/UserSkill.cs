using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class UserSkill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public DateTime CertificationDate { get; set; }
        public string ProficiencyLevel { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
