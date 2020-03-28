using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesInfoController : ControllerBase
    {
        public JsonResult GetEmployees()
        {
            return new JsonResult(new List<object>()
               {
                 new {employeeid = 01989, Name = "ohn Patrick"},
                 new {employeeid = 01987, Name= "Michael"},
                 new {employeeid = 01988, Name= "Akhil Mittal"}
               });
        }
    }
}