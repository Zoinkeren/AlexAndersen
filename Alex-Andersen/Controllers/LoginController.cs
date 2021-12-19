using Alex_Andersen.Models;
using Alex_Andersen.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Controllers
{
    public class LoginController : Controller
    {

        private readonly MyDbContext _context;

        public LoginController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ProcessLogin(User user)
        {


            SecurityService securityService = new SecurityService();


            if(securityService.IsValid(user))
            {
                return View("../home/index", user);
            }
            else
            {
                return View("LoginFailure", user);
            }

        }
        public IActionResult SignUp()
        {

            return View();
        }

    }
}
