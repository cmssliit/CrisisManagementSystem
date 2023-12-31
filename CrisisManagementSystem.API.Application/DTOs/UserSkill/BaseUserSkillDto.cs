﻿using System.ComponentModel.DataAnnotations;

namespace CrisisManagementSystem.API.Application.DTOs.UserSkill
{
    //we use abstract class because, we cant instantiate
    //only used for inheritance purposes
    public abstract class BaseUserSkillDto
    {
        //since following properties are repeatin in all 
        //Dtos we can put it in base
        //we can add the required anotation.
        //it will only consider when adding new user
        [Required]
        public string SkillName { get; set; }
        public DateTime CertificationDate { get; set; }
        public string ProficiencyLevel { get; set; }
        public int UserId { get; set; }
    }
}
