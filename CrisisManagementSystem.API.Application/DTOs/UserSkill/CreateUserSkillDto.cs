using CrisisManagementSystem.API.Application.DTOs.UserSkill;
using System.ComponentModel.DataAnnotations;

namespace CrisisManagementSystem.API.Application.DTOs.UserSkill
{
    //Introduce to add here Single Responsibilty priniciple.
    //Only to transfer data.Not to hold data from database
    public class CreateUserSkillDto : BaseUserSkillDto
    {
    }

    // This is feel repeating samething. but
    //it follows single responsibility prinicple
    // one clas for one purpose
    public class UpdateUserSkillDto : BaseUserSkillDto
    {
        public int Id { get; set; }
    }
}
