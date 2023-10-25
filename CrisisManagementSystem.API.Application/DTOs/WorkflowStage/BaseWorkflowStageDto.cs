using System.ComponentModel.DataAnnotations;

namespace CrisisManagementSystem.API.Application.DTOs.WorkflowStage
{
    //we use abstract class because, we cant instantiate
    //only used for inheritance purposes
    public abstract class BaseWorkflowStageDto
    {
        //since following properties are repeatin in all 
        //Dtos we can put it in base
        //we can add the required anotation.
        //it will only consider when adding new user
        [Required]
        public string StageName { get; set; }
        public string StageDescription { get; set; }
        public int TaskId { get; set; }
    }
}
