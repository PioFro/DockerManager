using System.Collections.Generic;
using System.Linq;
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

        [Ignore]
        public List<Resource> resources { get; set; }
        [Ignore]
        public List<Docker> dockers { get; set; }

        [Ignore]
        public string IpAddressString { get; set; }
        public Machine()
        {
            this.InitOneToMany(()=>Resources);
            this.InitOneToMany(()=>RunningDockers);
            resources = new List<Resource>();
            dockers = new List<Docker>();
        }

        public void SetVariables()
        {
            resources = Resources.ToList();
            if (resources == null)
                resources = new List<Resource>();
            
            dockers = RunningDockers.ToList();
            if (dockers == null)
                dockers = new List<Docker>();
            IpAddressString = IpAddress.ToString();
        }
    }
}