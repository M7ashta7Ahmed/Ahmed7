using AutoMapper;
using HR.Repositry.Serves;
using HR_Models.Models;
using HR_Models.Models.Creation;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.Http;
<<<<<<< HEAD
using Microsoft.AspNetCore.JsonPatch;
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniverCityController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IRepositryAllModels<UniverCity, UniverCitySummary> repositry;

        public UniverCityController(
            IMapper mapper,
            IRepositryAllModels<UniverCity, UniverCitySummary> repositry
            )
        {
            this.mapper = mapper;
            this.repositry = repositry;
        }


        [HttpGet]
        public async Task<ActionResult<List<UniverCitySummary>>> GetAllUniverCity()
        {
            var gets = repositry.GetAll();
            //var emp = mapper.Map<List<EmployeeSummary>>(gets);
            return Ok(gets);

        }

        [HttpGet("GetUniverCity/{id}")]
        public async Task<ActionResult<UniverCitySummary>> GetUniverCityId(Guid id)
        {
            var get = repositry.GetById(id);
            return Ok(get);
        }



        [HttpPost("/api/UniverCityAdded")]
        public async Task<ActionResult<UniverCity>> AddUniverCity([FromBody] UniverCityCreation univercity)
        {
            var map = mapper.Map<UniverCity>(univercity);

            var request = repositry.Add(map);

            return CreatedAtAction(nameof(GetAllUniverCity), new { id = request.id }, map);
        }



        [HttpPut("/api/PutsUniverCity/{id}")]
        public async Task<ActionResult<UniverCity>> PutUniverCity(Guid id, [FromBody] UniverCity univercity)
        {
<<<<<<< HEAD
           await repositry.Put(id, univercity);
=======
           await repositry.Patch(id, univercity);
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
            return NoContent();
        }

        [HttpDelete("Deleted")]
        public async Task<ActionResult<UniverCity>> Deleteunivercity(Guid id)
        {
            var delete = repositry.Delete(id);

            if (delete is null)
            {
                return BadRequest(" UniverCity Not Found ... ");
            }
            var univercitydelete = mapper.Map<UniverCitySummary>(delete);

            return NoContent();
        }




<<<<<<< HEAD
        [HttpPatch("/api/UniverCity/Patch")]
        public async Task<ActionResult<UniverCity>> UpdateUniverCity(Guid id, JsonPatchDocument<UniverCity> emp)
        {
            var patches = repositry.UpdateAsync(id, emp);
            if (patches == null)
            {
                return NotFound();
            }
            return Ok(patches);
        }
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3















    }
}
