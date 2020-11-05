using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;

namespace DockerManager.Controllers
{
    public class ResourceController : Controller
    {
        public static string Sender;
        public IActionResult Edit(string Id)
        {
            Resource env = DataProvider.GetResourceById(Id).Result;
            return View(env);
        }
        [HttpPost]
        public IActionResult Edit(Resource resource)
        {
            resource.SaveAsync();
            return RedirectToAction("Index", Sender);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Resource resource)
        {
            resource.SaveAsync();
            DockerController.SelectedDocker.RequiredResources.AddAsync(resource);
            //DockerController.ResourcesToAccept.Add(resource);
            return RedirectToAction("Edit", Sender, DockerController.SelectedDocker.ID,"");
        }
        public IActionResult Delete(string id)
        {
            DB.DeleteAsync<Resource>(id);
            return RedirectToAction("Index", Sender);
        }
    }
}
