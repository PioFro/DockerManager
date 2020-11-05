using System;
using MongoDB.Entities;
namespace DockerWebApplication.Models
{
    [Name("Variables")]
    public class EnvironmentalVariables:Entity
    {
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string Type{ get; set; }
        public string Value{ get; set; }
        public override string ToString()
        {
            return String.Format("Name: {0}, Description: {1}, Value: {2}, Type: {3}",Name, Description,Value,Type);
        }
    }
}