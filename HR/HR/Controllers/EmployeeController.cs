using AutoMapper;
using HR.Repositry.Serves;
using HR_Models.Models;
using HR_Models.Models.Creation;
using HR_Models.Models.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepositryAllModels<Employee,EmployeeSummary> repoEmp;
        private readonly IMapper mapper;
        private readonly IRepositryAllModels<City,CitySummary> repoCity;

        public EmployeeController(
            IRepositryAllModels<Employee, EmployeeSummary> repoEmp,
            IMapper mapper,
            IRepositryAllModels<City, CitySummary> RepoCity
            )
        {
            this.repoEmp = repoEmp;
            this.mapper = mapper;
            repoCity = RepoCity;
        }


        [HttpGet]
        public async Task<ActionResult<List<EmployeeSummary>>> GetAllEmployee()
        {
            var gets = repoEmp.GetAll();
            


            //var emp = mapper.Map<List<EmployeeSummary>>(gets);
            
            return Ok(gets);

        }

        [HttpGet("GetEmployee/{id}")]
        public async Task <ActionResult<EmployeeSummary>> GetEmployee(Guid id)
        {
            var get = repoEmp.GetById(id);
            return Ok(get);
        }  



        [HttpPost("/api/AddEmployee")]
        public async Task<ActionResult<Employee>> AddEmployee([FromBody] EmployeeCreation employee)
        {
            var map = mapper.Map<Employee>(employee);

            var request = repoEmp.Add(map);
            return CreatedAtAction(nameof(GetAllEmployee), new { id = request.id }, map);
        }



        [HttpPut("/api/PutEmployee/{id}")]
        public async Task<ActionResult<Employee>> PutEmployee(Guid id,[FromBody] Employee employee)
        {
          
            await repoEmp.Patch(id,employee);
            
            return NoContent();

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


        





    }


}


