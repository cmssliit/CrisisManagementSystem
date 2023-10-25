using System.ComponentModel.DataAnnotations;

namespace CrisisManagementSystem.API.DataLayer
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<WorkflowTask> WorkflowTasks { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }

    }
}
