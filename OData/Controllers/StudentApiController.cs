using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.Model;
using OData.Repository;
using System.Collections.Generic;

namespace OData.Controllers
{
    public class StudentsController : ControllerBase
    {
        [HttpGet,EnableQuery()]
        public ActionResult<IEnumerable<Student>> Get() {

            return StudentManagementSystemRepository.GetStudents;

        }
    }
}