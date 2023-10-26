﻿using CrisisManagementSystem.API.DataLayer;
using CrisisManagementSystem.API.Application.IRepository;
using CrisisManagementSystem.API.DataLayer.Entities;

namespace CrisisManagementSystem.API.Application.Repository
{
    public class WorkflowTaskRepository : GenericRepository<WorkflowTask>, IWorkflowTaskRepository
    {
        public WorkflowTaskRepository(CrisisManagementDbContext context) : base(context)
        {
        }
    }
}