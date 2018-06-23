using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]

    public class UserController : Controller
    {
        public IActionResult GetAll()
        {
            List<Users> users = new List<Users>();
            return Users;
        }
    }
}
