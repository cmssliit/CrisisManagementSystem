
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrisisManagementSystem.API.DataLayer;
using CrisisManagementSystem.API.Application.DTOs.UserSkill;
using AutoMapper;
using CrisisManagementSystem.API.Application.IRepository;
using CrisisManagementSystem.API.Application.DTOs.User;

namespace CrisisManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSkillsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserSkillRepository _userSkillRepository;

        //since we register our dbcontext with builder.services in program.cs
        //it geives the ability to inject almost anyfile wewant
        public UserSkillsController(IMapper mapper,IUserSkillRepository userSkillRepository)
        {
            _mapper = mapper;
            _userSkillRepository = userSkillRepository;
        }

        // GET: api/UserSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetUserSkillDto>>> GetUserSkills()
        {
          if (await _userSkillRepository.GetAllAsync() == null)
          {
              return NotFound();
          }
            var userSkills = await _userSkillRepository.GetAllAsync();

            var getuserSkills = _mapper.Map<List<GetUserSkillDto>>(userSkills);

            return Ok(getuserSkills); 
        }

        // GET: api/UserSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserSkill>> GetUserSkill(int id)
        {
          if (await _userSkillRepository.GetAllAsync() == null)
          {
              return NotFound();
          }
            var userSkill = await _userSkillRepository.GetAsync(id);

            if (userSkill == null)
            {
                return NotFound();
            }

            return userSkill;
        }

        // PUT: api/UserSkills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserSkill(int id, UpdateUserSkillDto updateUserSkill)
        {
            if (id != updateUserSkill.Id)
            {
                return BadRequest();
            }

            // _context.Entry(updateUserSkill).State = EntityState.Modified;

            var userSkill = await _userSkillRepository.GetAsync(id);//from this line entity get tracked.
            if (userSkill == null)
            {
                return NotFound();
            }

            _mapper.Map(updateUserSkill,userSkill); //from this line it get modified

            try
            {
                await _userSkillRepository.UpdateAsync(userSkill);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserSkillExists(id))
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

        // POST: api/UserSkills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserSkill>> PostUserSkill(CreateUserSkillDto createUserSkill)
        {
          var userSkill = _mapper.Map<UserSkill>(createUserSkill);

            await _userSkillRepository.AddAsync(userSkill);

            return CreatedAtAction("GetUserSkill", new { id = userSkill.Id }, userSkill);
        }

        // DELETE: api/UserSkills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserSkill(int id)
        {
            if (await _userSkillRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var userSkill = await _userSkillRepository.GetAsync(id);
            if (userSkill == null)
            {
                return NotFound();
            }

            await _userSkillRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> UserSkillExists(int id)
        {
            return await _userSkillRepository.Exists(id);
        }
    }
}
