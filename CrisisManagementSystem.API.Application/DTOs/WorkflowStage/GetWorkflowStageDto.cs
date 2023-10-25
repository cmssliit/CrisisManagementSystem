namespace CrisisManagementSystem.API.Application.DTOs.WorkflowStage
{
    //we create this dto to single responsiblity princiepl
    // and avoid sending unnersseary data like navigation properties etc
    public class GetWorkflowStageDto : BaseWorkflowStageDto
    {
        public int Id { get; set; }
    }
}
