using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Entities;

namespace DockerWebApplication.Models
{
    public class DataProvider
    {
        public static User LoggedUser;
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

        public async static Task<EnvironmentalVariables> GetEnvironmentalVariableById(string id)
        {
            return await DB.Find<EnvironmentalVariables>().OneAsync(id);
        }
        public async static Task<bool> CanCreateUser(User user)
        {
            var nameCount = await DB.CountAsync<User>(a => a.Name.Equals(user.Name));
            var emailCount = await DB.CountAsync<User>(a => a.Name.Equals(user.Email));
            return emailCount == 0 && nameCount == 0;
        }
        public async static Task<Resource> GetResourceById(string id)
        {
            return await DB.Find<Resource>().OneAsync(id);
        }
        public async static Task<List<Docker>> GetDockersByUserId(string id)
        {
            var usr = await DB.Find<User>().OneAsync(id);
            return usr.GetDockers();
        }
        public async static Task<List<Machine>> GetMachinesByUserId(string id)
        {
            var usr = await DB.Find<User>().OneAsync(id);
            return usr.Machines.ToList();
        }
        public async static Task<Machine> GetMachineById(string id)
        {
            return await DB.Find<Machine>().OneAsync(id);
        }
        public async static Task<Docker> GetDockerById(string id)
        {
            return await DB.Find<Docker>().OneAsync(id);
        }

    }
}