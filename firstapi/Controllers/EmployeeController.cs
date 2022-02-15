using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstapi.Models;

namespace firstapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("AllEmps")]
        public ActionResult<List<Employee>> getAllEmployees(){
            using(var db=new DatabaseTrainingContext()){
                var emps=db.Employees.ToList();
                return Ok(emps);
            }
        }

        [HttpGet]
        [Route("EmpbyID/{id}")]
        public async Task<ActionResult<Employee>> getEmpById(int id){
            using (var db=new DatabaseTrainingContext())
            {
                Employee obj=await db.Employees.FindAsync(id);
                return Ok(obj);
            }
        }

        [HttpPost]
        [Route("AddEmp")]
        public async Task<ActionResult> AddEmployee(Employee e){
            using (var db=new DatabaseTrainingContext()){
                db.Employees.Add(e);
                await db.SaveChangesAsync();
                return Ok(e);
            }
        }

        [HttpPut]
        [Route("EditEmp")]
        public async Task<ActionResult> ModifyEmployee(int id,Employee e){
            using(var db=new DatabaseTrainingContext()){
                db.Employees.Update(e);
                await db.SaveChangesAsync();
                return Ok(e);
            }
        }

        [HttpDelete]
        [Route("DeleteEmp")]
        public async Task<ActionResult> DeleteEmployee(int id){
            using(var db=new DatabaseTrainingContext()){
               Employee e = db.Employees.Find(id);
               db.Employees.Remove(e);
               await db.SaveChangesAsync();
                return Ok();
            }
        }
    }
}