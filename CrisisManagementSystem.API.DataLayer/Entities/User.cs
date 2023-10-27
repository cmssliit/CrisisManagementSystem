﻿using System.ComponentModel.DataAnnotations;

namespace CrisisManagementSystem.API.DataLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}