using System.ComponentModel.DataAnnotations.Schema;

namespace CrisisManagementSystem.API.DataLayer
{
    public class WorkflowStage
    {
        public int Id { get; set; }
        public string StageName { get; set; }
        public string StageDescription { get; set; }
        public int TaskId { get; set; }
        public WorkflowTask WorkflowTasks { get; set; }
        public List<Workflow> Workflows { get; set; }

    }
}
