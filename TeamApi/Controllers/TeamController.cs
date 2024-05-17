using Microsoft.AspNetCore.Mvc;
using PARCIALDB.DOMAIN.Core.Entities;
using TeamApi.Core.Interfaces;

namespace TeamApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamRepository _categoryRepository;


        public TeamController(ITeamRepository tRepository)
        { 
             _categoryRepository =  tRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryRepository.GetAll();
            return Ok(categories);
        }

      
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Team category)
        {
           if (id != category.Id) return BadRequest();
            var result = await _categoryRepository.Update(category);
           if (!result) return BadRequest();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _categoryRepository.Delete(id);
            if (!result) return BadRequest();
            return Ok(result);
        }

    }
}

