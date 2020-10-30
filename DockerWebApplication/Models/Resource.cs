using System;
using MongoDB.Entities;
namespace DockerWebApplication.Models
{
    [Name("Resources")]
    public class Resource:Entity
    {
        public string Name{ get; set; }
        public string Type{ get; set; }
        public string Value{ get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Value: {1}, Type: {2}",Name, Value,Type);
        }
    }
}