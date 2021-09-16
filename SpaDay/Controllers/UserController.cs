using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/User")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.user = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.password = newUser.Password;
            ViewBag.verify = verify;
            ViewBag.dateJoined = newUser.DateJoined;

            if(newUser.Password == verify)
            {
                ViewBag.IsError = false;
                return View("Index");
            }
            else
            {
                ViewBag.IsError = true;
                ViewBag.error = "Your passwords do not match!";
                return View("Add");
            }
        }
    }
}
