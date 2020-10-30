using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Entities;
namespace DockerWebApplication.Models
{ 
    [Name("Users")]
    public class User:Entity
    {
       
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public Many<Docker> Dockers { get; set; }
        
        public Many<Machine> Machines{ get; set; }

        public User()
        {
            this.InitOneToMany(()=>Dockers);
            this.InitOneToMany(()=>Machines);
        }

        public List<Docker> GetDockers()
        {
            return Dockers.ToList();
        }

        public Task<List<Docker>> GetDockersTask()
        {
            Func<List<Docker>> dockers = GetDockers;
            return new Task<List<Docker>>(dockers);
        }
    }
}