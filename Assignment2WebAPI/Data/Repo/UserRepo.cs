using System;
using System.Threading.Tasks;
using Assignment2WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Assignment2WebAPI.Data.Repo
{
    public class UserRepo:IUser
    {
        private FileDBContext ctx;
        public UserRepo(FileDBContext ctx)
        {
            this.ctx = ctx;
        }
       
      
        public async Task<User> ValidateUser(string userName, string Password)
        {
           
            User temp = await ctx.Users.FirstOrDefaultAsync(u => u.UserName.Equals(userName));
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