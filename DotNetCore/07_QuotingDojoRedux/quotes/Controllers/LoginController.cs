using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperApp.Models;
using DapperApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;



namespace DapperApp.Controllers
{
    public class LoginController : Controller
    {


        private readonly UserRepository userRepository;

        public LoginController(UserRepository user) {         
            userRepository = user;
        }

       [HttpGet]
       [Route("/")]
       public IActionResult Registration()
       {    
           ViewBag.Errors = new List<string>();
           return View();
       }
        
       [HttpGet]
       [Route("login")]
       public IActionResult Login()
       {    
           ViewBag.Errors = new List<string>();
           return View();
       }

       [HttpPost]
       [Route("register")]
       public IActionResult Register(User user)
       {
           if(ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.password = Hasher.HashPassword(user, user.password);
                TryValidateModel(user);
                userRepository.Add(user);

                //Save your user object to the database
                return View("Login");
            }

            ViewBag.Errors = ModelState.Values;
            return View("Registration");//error goes back to page with errors
       }

       [HttpPost]
       [Route("login")]
       public IActionResult LoginUser(string Email, string PasswordToCheck)
       {
            User user = userRepository.FindByEmail(Email);

            if(user != null)
            {   
                var Hasher = new PasswordHasher<User>();

                // Pass the User object, the hashed password, and the password to check
                if(0 != Hasher.VerifyHashedPassword(user, user.password, PasswordToCheck))
                {
                    //Handle success
                    ViewBag.user = user.name;
                    HttpContext.Session.SetString("name", user.name);
                    HttpContext.Session.SetInt32("id", (int)user.Id);
                    TempData["Stuff"] = "Success!";
                    return RedirectToAction("Quotes", "Quote");

                }
                
            }
            
            //if above check for user fails, runs below code
            TempData["Stuff"] = "Failed Login";
            return View("Login");   
       }





       
    }
}
