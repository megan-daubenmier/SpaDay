using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Username = newUser.Username,
                    Email = newUser.Email,
                    Password = newUser.Password
                };
                return View("Index", newUser);
            }
            else
            {
                ViewBag.userName = newUser.Username;
                ViewBag.eMail = newUser.Email;
                return View("Add", newUser);
            }
        }

    }
}
