using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerManager.Controllers
{
    public class DockerController : Controller
    {
        static List<Docker> tmpDockers;
        public IActionResult Index(IEnumerable<DockerWebApplication.Models.Docker> dockers)
        {
            var d = UserController.LoginUser.Dockers.ToList();
            tmpDockers = d;
            return View(d);
        }

        public IActionResult Edit(int id)
        {
            var selectedDocker = tmpDockers[id];
            selectedDocker.SetVariables();
            return View(selectedDocker);
        }

    }
}
