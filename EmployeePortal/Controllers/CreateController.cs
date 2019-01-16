using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    public class CreateController : Controller
    {
        List<Employee> emp = new List<Employee>()
        {
            new Employee{Id=1, Name= "Rahul", Designation="software eng",Exp=2},
            new Employee{Id=2, Name= "Priya", Designation="senior software eng",Exp=5},
            new Employee{Id=3, Name= "Anand", Designation="software eng",Exp=2},
            new Employee{Id=4, Name= "Sowmiya", Designation="Technical lead",Exp=9},
            new Employee{Id=5, Name= "John", Designation="software eng",Exp=1},
        };
        [Route("api")]
        public ActionResult<Dictionary<string, Employee>> getEmployee()
        {
            return Ok(emp);
        }


    
    }
}