using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class WorkflowTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int AssigneeId { get; set; }
        public User Users { get; set; }
        public DateTime Deadline { get; set; }
        public List<WorkflowStage> WorkflowStages { get; set; }

    }
}
