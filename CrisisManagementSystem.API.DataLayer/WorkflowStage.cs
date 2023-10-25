using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class WorkflowStage
    {
        public int Id { get; set; }
        public string StageName { get; set; }
        public string StageDescription { get; set; }
        public int TaskId { get; set; }
        public virtual WorkflowTask Task { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }

    }
}
