using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DockerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Entities;

namespace DockerManager.Controllers
{
    public class MachineController : Controller
    {
        public static Machine CurrentMachine;
        public IActionResult Index()
        {
            EnvironmentalVariablesController.Sender = "Machine";
            ResourceController.Sender = "Machine";

            var machines = DataProvider.GetMachinesByUserId(UserController.LoginUser.ID).Result;
            machines.ForEach(a => a.SetVariables());

            return View(machines);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Machine machine)
        {
            try { machine.IpAddress = IPAddress.Parse(machine.IpAddressString); }
            catch { machine.IpAddress = IPAddress.Loopback; }
            machine.SaveAsync();
            UserController.LoginUser.Machines.AddAsync(machine);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(string id)
        {
            var machine = CurrentMachine;
            if (id != null)
            {
                machine = DataProvider.GetMachineById(id).Result;
                machine.SetVariables();
                CurrentMachine = machine;
            }
            machine.dockers.ForEach(a => a.SetVariables());
            return View(CurrentMachine);
        }
        public IActionResult Stop(string id)
        {
            //Stop docker;
            var d = DataProvider.GetDockerById(id).Result;
            CurrentMachine.RunningDockers.RemoveAsync(d);
            return RedirectToAction("Index");
        }
        //Machine to run + list of dockers
        public IActionResult Run(string id)
        {
            //Get machine
            var machine = CurrentMachine;
            if (id != null)
            {
                machine = DataProvider.GetMachineById(id).Result;
            }
            CurrentMachine = machine;
            ViewBag.Message = machine.Name;
            //TODO: Check only those that fulfill the requirements
            var dockers = DataProvider.GetDockersByUserId(UserController.LoginUser.ID).Result;
            dockers.ForEach(a => a.SetVariables());
            return View(dockers);
        }
        public IActionResult RunDocker(string id)
        {
            var d = DataProvider.GetDockerById(id).Result;
            CurrentMachine.RunningDockers.AddAsync(d);
            return RedirectToAction("Index");
        }

    }
}
