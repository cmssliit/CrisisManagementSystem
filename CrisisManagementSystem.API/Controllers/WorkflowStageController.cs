
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrisisManagementSystem.API.DataLayer;
using CrisisManagementSystem.API.Application.DTOs.WorkflowStage;
using AutoMapper;
using CrisisManagementSystem.API.Application.IRepository;
using CrisisManagementSystem.API.Application.DTOs.User;

namespace CrisisManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowStagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWorkflowStageRepository _workflowStageRepository;

        //since we register our dbcontext with builder.services in program.cs
        //it geives the ability to inject almost anyfile wewant
        public WorkflowStagesController(IMapper mapper,IWorkflowStageRepository workflowStageRepository)
        {
            _mapper = mapper;
            _workflowStageRepository = workflowStageRepository;
        }

        // GET: api/WorkflowStages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetWorkflowStageDto>>> GetWorkflowStages()
        {
          if (await _workflowStageRepository.GetAllAsync() == null)
          {
              return NotFound();
          }
            var workflowStages = await _workflowStageRepository.GetAllAsync();

            var getworkflowStages = _mapper.Map<List<GetWorkflowStageDto>>(workflowStages);

            return Ok(getworkflowStages); 
        }

        // GET: api/WorkflowStages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkflowStage>> GetWorkflowStage(int id)
        {
          if (await _workflowStageRepository.GetAllAsync() == null)
          {
              return NotFound();
          }
            var workflowStage = await _workflowStageRepository.GetAsync(id);

            if (workflowStage == null)
            {
                return NotFound();
            }

            return workflowStage;
        }

        // PUT: api/WorkflowStages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkflowStage(int id, UpdateWorkflowStageDto updateWorkflowStage)
        {
            if (id != updateWorkflowStage.Id)
            {
                return BadRequest();
            }

            // _context.Entry(updateWorkflowStage).State = EntityState.Modified;

            var workflowStage = await _workflowStageRepository.GetAsync(id);//from this line entity get tracked.
            if (workflowStage == null)
            {
                return NotFound();
            }

            _mapper.Map(updateWorkflowStage,workflowStage); //from this line it get modified

            try
            {
                await _workflowStageRepository.UpdateAsync(workflowStage);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await WorkflowStageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WorkflowStages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkflowStage>> PostWorkflowStage(CreateWorkflowStageDto createWorkflowStage)
        {
          var workflowStage = _mapper.Map<WorkflowStage>(createWorkflowStage);

            await _workflowStageRepository.AddAsync(workflowStage);

            return CreatedAtAction("GetWorkflowStage", new { id = workflowStage.Id }, workflowStage);
        }

        // DELETE: api/WorkflowStages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkflowStage(int id)
        {
            if (await _workflowStageRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var workflowStage = await _workflowStageRepository.GetAsync(id);
            if (workflowStage == null)
            {
                return NotFound();
            }

            await _workflowStageRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> WorkflowStageExists(int id)
        {
            return await _workflowStageRepository.Exists(id);
        }
    }
}
