using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2WebAPI.Data;
using Models;

namespace Assignment2WebAPI.Data
{
    public class InMemoryUser : IUser
    {
        private List<User> users;

        public InMemoryUser()

        {
            users = new[]
            {
                new User()
                {
                    UserName = "dorin", Password = "1234",Level="user"
                },
                new User()
                {
                    UserName = "admin", Password = "admin",Level = "admin"
                }
            }.ToList();
        }

        public async Task<User> ValidateUser(string userName, string Password)
        {
        
            User temp = users.FirstOrDefault(u => u.UserName == userName);
            if (temp == null)
            {
                throw new Exception("User not found");
            }

            if (!temp.Password.Equals(Password))
            {
              
                throw new Exception("Incorrect password");
            }

            return temp;
        }
    }
}