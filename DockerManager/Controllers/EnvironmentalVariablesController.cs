using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;

namespace DockerManager.Controllers
{
    public class EnvironmentalVariablesController : Controller
    {
        public static string Sender;
        public IActionResult Edit(string Id)
        {
            EnvironmentalVariables env = DataProvider.GetEnvironmentalVariableById(Id).Result;
            return View(env);
        }
        [HttpPost]
        public IActionResult Edit(EnvironmentalVariables env)
        {
            env.SaveAsync();
            return RedirectToAction("Index",Sender);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EnvironmentalVariables env)
        {
            env.SaveAsync();
            DockerController.SelectedDocker.PossibleVariables.AddAsync(env);
            return RedirectToAction("Edit", Sender, DockerController.SelectedDocker.ID,"");
        }
        public IActionResult Delete(string id)
        {
            DB.DeleteAsync<EnvironmentalVariables>(id);
            return RedirectToAction("Index", Sender);
        }

    }
}
