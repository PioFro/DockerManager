using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Entities;
namespace DockerWebApplication.Models
{
    [Name("Dockers")]
    public class Docker:Entity
    {
        public string Name{ get; set; }
        public DateTime LastUsedDate { get; set; }
        public string PullName{ get; set; }
        public Many<EnvironmentalVariables> PossibleVariables{ get; set; }
        public Many<Resource> RequiredResources{ get; set; }

        [Ignore]
        public int Variables { get; set; }

        [Ignore]
        public List<EnvironmentalVariables> v { get; set; }

        [Ignore]
        public List<Resource> resources { get; set; }
        [Ignore]
        public int Resoures { get; set; }

        public void SetVariables()
        {
            Variables = PossibleVariables.Count();
            Resoures = RequiredResources.Count();
            v = PossibleVariables.ToList();
            resources = RequiredResources.ToList();
        }

        public Docker()
        {
            this.InitOneToMany(()=>PossibleVariables);
            this.InitOneToMany(()=>RequiredResources);
            v = new List<EnvironmentalVariables>();
            resources = new List<Resource>();
        }

        public override string ToString()
        {
            String resourceString = "", varString = "";
            try
            {
                foreach (var resource in RequiredResources.ToList())
                {
                    resourceString += resource.ToString() + "\n";
                }
            }
            catch
            {
                resourceString = "Unable to fetch required resources";
            }
            try
            {
                foreach (var v in PossibleVariables)
                {
                    varString += v.ToString() + "\n";
                }
            }
            catch
            {
                varString = "Unable to fetch possible variables";
            }

            return String.Format(
                "Name: {0}, " +
                "Pull Name: {1}, " +
                "Last Used: {2} " +
                "\nRequred Resources {3}" +
                "\nPossible Environmental Variables {4}",
                Name, PullName, LastUsedDate.ToString(), resourceString, varString);
        }
        
    }
}