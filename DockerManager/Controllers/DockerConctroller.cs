using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;

namespace DockerManager.Controllers
{
    public class DockerController : Controller
    {
        static List<Docker> tmpDockers;
        public static Docker SelectedDocker;
        public IActionResult Index()
        {
            EnvironmentalVariablesController.Sender = "Docker";
            ResourceController.Sender = "Docker";
            var d = DataProvider.GetDockersByUserId(UserController.LoginUser.ID).Result;
            tmpDockers = d;
            tmpDockers.ForEach(a => a.SetVariables());
            SelectedDocker = new Docker();
            return View(d);
        }
        public IActionResult Edit(string id)
        {
            if (id != null)
            {
                var selectedDocker = DB.Find<Docker>().OneAsync(id).Result;

                selectedDocker.SetVariables();
                SelectedDocker = selectedDocker;
            }
            SelectedDocker.SetVariables();
            return View(SelectedDocker);
        }

        [HttpPost]
        public IActionResult Edit(Docker docker)
        {
            docker.SaveAsync();
            return RedirectToAction("Index", "Docker");
        }
        public IActionResult Delete(string id)
        {
            DB.DeleteAsync<Docker>(id);
            return RedirectToAction("Index", "Docker");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Docker docker)
        {
            docker.SaveAsync();
            UserController.LoginUser.Dockers.AddAsync(docker);
            return RedirectToAction("Index", "Docker");
        }
    }
}
