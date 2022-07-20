using DemoClass.Models;
using DemoClass.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClass.Controllers
{
    public class HomeController : Controller
    {//we want to inject the iservice here so we create a private read only field and a constructor for it
        private readonly IService _iservice;
        public HomeController(IService service)
        {
            _iservice = service;
        }
        //IActionResult is a general return type
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Project()
        {
            var myProject = _iservice.MyProjects;
            var proj = new List<Project>();

            foreach (var m in myProject)
            {
                proj.Add(new Project
                {
                    Id = m.Id,
                    Description = m.Description,
                    Title = m.Title,
                    Images = m.Images,
                    DateCreated = m.DateCreated,
                });
            }
            return View(proj);
        }
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
