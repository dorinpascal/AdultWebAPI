using System;
using System.Threading.Tasks;
using Models;

namespace Assignment2WebAPI.Data
{
    public interface IUser
    {
        
        Task<User> ValidateUser(string userName, string Password);
    }
}