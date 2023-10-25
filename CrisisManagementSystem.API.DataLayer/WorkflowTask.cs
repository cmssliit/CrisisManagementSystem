using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class WorkflowTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int AssigneeId { get; set; }
        public virtual User Assignee { get; set; }
        public DateTime Deadline { get; set; }
        public virtual ICollection<WorkflowStage> WorkflowStages { get; set; }

    }
}
