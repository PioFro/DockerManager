using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Entities;

namespace DockerWebApplication.Models
{
    public class DataProvider
    {
        public async static Task ConnectToDB()
        {
            await DB.InitAsync("Dockers", "localhost", 27017);
        }

        public async static Task<List<Docker>> GetDockersByName(string name)
        {
            return await DB.Find<Docker>().ManyAsync(a => a.Name == name);
        }

        public async static Task<List<User>> GetUserByName(string name)
        {
            return await DB.Find<User>().ManyAsync(a => a.Name == name);
        }

        public async static Task<List<User>> GetUserByEmail(string email)
        {
            return await DB.Find<User>().ManyAsync(a => a.Email.Equals(email));
        }
    }
}