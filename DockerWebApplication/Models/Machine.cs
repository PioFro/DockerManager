using System.Net;
using MongoDB.Entities;

namespace DockerWebApplication.Models
{
    [Name("Machines")]
    public class Machine:Entity
    {
        public string Name{ get; set; }
        public IPAddress IpAddress{ get; set; }
        public Many<Resource> Resources { get; set; }
        public Many<Docker> RunningDockers { get; set; }

        public Machine()
        {
            this.InitOneToMany(()=>Resources);
            this.InitOneToMany(()=>RunningDockers);
        }
    }
}