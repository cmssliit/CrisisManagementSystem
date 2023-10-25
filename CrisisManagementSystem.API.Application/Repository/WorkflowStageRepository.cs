using CrisisManagementSystem.API.DataLayer;
using CrisisManagementSystem.API.Application.IRepository;

namespace CrisisManagementSystem.API.Application.Repository
{
    public class WorkflowStageRepository : GenericRepository<WorkflowStage>, IWorkflowStageRepository
    {
        public WorkflowStageRepository(CrisisManagementDbContext context) : base(context)
        {
        }
    }
}
