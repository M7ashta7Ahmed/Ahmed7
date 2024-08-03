using AutoMapper;
<<<<<<< HEAD
using HR.Repositry;
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
using HR.Repositry.Serves;
using HR_Models.Models;
using HR_Models.Models.Creation;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using Microsoft.AspNetCore.JsonPatch;
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepositryAllModels<Employee,EmployeeSummary> repoEmp;
        private readonly IMapper mapper;
        private readonly IRepositryAllModels<City,CitySummary> repoCity;
<<<<<<< HEAD
        private readonly RepoEmployee repo;
        private readonly IRepositryUpdate<Employee> repoupdate;
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

        public EmployeeController(
            IRepositryAllModels<Employee, EmployeeSummary> repoEmp,
            IMapper mapper,
<<<<<<< HEAD
            IRepositryAllModels<City, CitySummary> RepoCity,
            RepoEmployee repo,
            IRepositryUpdate< Employee> repoupdate
=======
            IRepositryAllModels<City, CitySummary> RepoCity
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
            )
        {
            this.repoEmp = repoEmp;
            this.mapper = mapper;
            repoCity = RepoCity;
<<<<<<< HEAD
            this.repo = repo;
            this.repoupdate = repoupdate;
=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        }


        [HttpGet]
        public async Task<ActionResult<List<EmployeeSummary>>> GetAllEmployee()
        {
            var gets = repoEmp.GetAll();
<<<<<<< HEAD

            //var emp = mapper.Map<List<EmployeeSummary>>(gets);
=======
            


            //var emp = mapper.Map<List<EmployeeSummary>>(gets);
            
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
            return Ok(gets);

        }

<<<<<<< HEAD
        [HttpGet("GetEmployee/{id:guid}")]
=======
        [HttpGet("GetEmployee/{id}")]
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        public async Task <ActionResult<EmployeeSummary>> GetEmployee(Guid id)
        {
            var get = repoEmp.GetById(id);
            return Ok(get);
        }  

<<<<<<< HEAD
=======


>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        [HttpPost("/api/AddEmployee")]
        public async Task<ActionResult<Employee>> AddEmployee([FromBody] EmployeeCreation employee)
        {
            var map = mapper.Map<Employee>(employee);

            var request = repoEmp.Add(map);
            return CreatedAtAction(nameof(GetAllEmployee), new { id = request.id }, map);
        }

<<<<<<< HEAD
        [HttpPut("/api/PutEmployee/{id}")]
        public async Task<ActionResult<Employee>> PutEmployee(Guid id, [FromBody] Employee employee)
        {
            var updatedEmployee = await repoEmp.Put(id, employee);

            if (updatedEmployee == null)
            {
                return NotFound(); 
            }
            return NoContent(); 
=======


        [HttpPut("/api/PutEmployee/{id}")]
        public async Task<ActionResult<Employee>> PutEmployee(Guid id,[FromBody] Employee employee)
        {
          
            await repoEmp.Patch(id,employee);
            
            return NoContent();

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3
        }

        [HttpDelete("Deleted")]
        public async Task<ActionResult<Employee>>DeleteEmployee(Guid id)
        {
            var delete =repoEmp.Delete(id);

            if (delete is null)
            {
                return BadRequest(" Employee Not Found ... ");
            }
            var empdelete = mapper.Map<EmployeeSummary>(delete);

            return NoContent(); 
        }

<<<<<<< HEAD
        [HttpPatch("/api/Patch")]
        public async Task<ActionResult<Employee>> UpdateEmployee(Guid id,JsonPatchDocument<Employee> emp)
        {
            var patches = repoEmp.UpdateAsync(id,emp);
            if (patches == null)
            {
                return NotFound();
            }
            return Ok(patches);
        }







     

      /// <summary>
      /// /////////////
      /// </summary>
      /// <returns></returns>

        [HttpGet("Api/EmployeeinSalarys")]
        public async Task<ActionResult<List<Employee>>> GetEmployeeInSalarys()
        {
            var responce = repoEmp.GetAllEmplyeeAndSalarys();
            if (responce == null)
            {
                return BadRequest(" is Employee null City");
            }

            var json = JsonConvert.SerializeObject(responce, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });


            return Ok(json);
        }


=======
>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

        



<<<<<<< HEAD
        
=======

>>>>>>> 9671e78d072c5d063b832621597579a2a7aeb1b3

    }


}


