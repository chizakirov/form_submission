using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using form_submission.Models;

namespace form_submission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            //if you want to prepopulate edit form fields, then pass a model object to View. Otherwise, don't need this
            // User userModel = new User();
            return View("index");
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View("result");
        }

        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("Model state is valid");
                return RedirectToAction("result", user);
            }
            else
            {
                Console.WriteLine("NOT VALID**************", ModelState.Keys);
                foreach(var error in ModelState)
                {
                    if (error.Value.Errors.Count > 0)
                    {
                        Console.WriteLine("ERR MSG: ", error.Value.Errors[0].ErrorMessage);
                    }
                   
                }
                
                return View("index");
            }
        }
    }
}
