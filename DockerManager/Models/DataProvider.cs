using System;
using System.Collections.Generic;
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
        public async static Task<bool> CanCreateUser(User user)
        {
            var nameCount = await DB.CountAsync<User>(a => a.Name.Equals(user.Name));
            var emailCount = await DB.CountAsync<User>(a => a.Name.Equals(user.Email));
            return emailCount == 0 && nameCount == 0;
        }
    }
}