using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class Workflow
    {
        public int Id { get; set; }
        public string WorkflowName { get; set; }
        public string WorkflowDescription { get; set; }
        public int StageId { get; set; }
        public virtual WorkflowStage Stage { get; set; }

    }
}
