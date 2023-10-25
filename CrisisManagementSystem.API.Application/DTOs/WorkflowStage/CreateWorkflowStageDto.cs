using CrisisManagementSystem.API.Application.DTOs.WorkflowStage;
using System.ComponentModel.DataAnnotations;

namespace CrisisManagementSystem.API.Application.DTOs.WorkflowStage
{
    //Introduce to add here Single Responsibilty priniciple.
    //Only to transfer data.Not to hold data from database
    public class CreateWorkflowStageDto : BaseWorkflowStageDto
    {
    }

    // This is feel repeating samething. but
    //it follows single responsibility prinicple
    // one clas for one purpose
    public class UpdateWorkflowStageDto : BaseWorkflowStageDto
    {
        public int Id { get; set; }
    }
}
