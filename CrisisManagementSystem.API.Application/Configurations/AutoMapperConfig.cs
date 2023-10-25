using AutoMapper;
using CrisisManagementSystem.API.DataLayer;

namespace CrisisManagementSystem.API.Application.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Auto mapper will use the name of the property and will autamaticlly map
            CreateMap<User, DTOs.User.CreateUserDto>().ReverseMap();
            CreateMap<User, DTOs.User.GetUserDto>().ReverseMap();
            CreateMap<User, DTOs.User.UpdateUserDto>().ReverseMap();

            CreateMap<Department, DTOs.Department.CreateDepartmentDto>().ReverseMap();
            CreateMap<Department, DTOs.Department.GetDepartmentDto>().ReverseMap();
            CreateMap<Department, DTOs.Department.UpdateDepartmentDto>().ReverseMap();

            CreateMap<Location, DTOs.Location.CreateLocationDto>().ReverseMap();
            CreateMap<Location, DTOs.Location.GetLocationDto>().ReverseMap();
            CreateMap<Location, DTOs.Location.UpdateLocationDto>().ReverseMap();

            CreateMap<WorkflowTask, DTOs.WorkflowTask.CreateWorkflowTaskDto>().ReverseMap();
            CreateMap<WorkflowTask, DTOs.WorkflowTask.GetWorkflowTaskDto>().ReverseMap();
            CreateMap<WorkflowTask, DTOs.WorkflowTask.UpdateWorkflowTaskDto>().ReverseMap();

            CreateMap<WorkflowStage, DTOs.WorkflowStage.CreateWorkflowStageDto>().ReverseMap();
            CreateMap<WorkflowStage, DTOs.WorkflowStage.GetWorkflowStageDto>().ReverseMap();
            CreateMap<WorkflowStage, DTOs.WorkflowStage.UpdateWorkflowStageDto>().ReverseMap();

            CreateMap<Workflow, DTOs.Workflow.CreateWorkflowDto>().ReverseMap();
            CreateMap<Workflow, DTOs.Workflow.GetWorkflowDto>().ReverseMap();
            CreateMap<Workflow, DTOs.Workflow.UpdateWorkflowDto>().ReverseMap();
        }
    }
}
