using CrisisManagementSystem.API.DataLayer;
using CrisisManagementSystem.API.Application.IRepository;

namespace CrisisManagementSystem.API.Application.Repository
{
    public class UserSkillRepository : GenericRepository<UserSkill>, IUserSkillRepository
    {
        public UserSkillRepository(CrisisManagementDbContext context) : base(context)
        {
        }
    }
}
