using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class DepartmentsController : Controller
    {
        public string List()
        {
            return "Dept-controller List-action";
        }

        public string Details()
        {
            return "Dept-controller Details-action";
        }
    }
}