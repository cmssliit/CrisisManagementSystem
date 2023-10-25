namespace CrisisManagementSystem.API.Application.DTOs.UserSkill
{
    //we create this dto to single responsiblity princiepl
    // and avoid sending unnersseary data like navigation properties etc
    public class GetUserSkillDto : BaseUserSkillDto
    {
        public int Id { get; set; }
    }
}
