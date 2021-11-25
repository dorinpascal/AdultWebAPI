using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2WebAPI.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;

namespace Assignment2WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //one time call 
            // addUser();
            // addAdult();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });


        //adding the adults in the database
        public static void addAdult()
        {
            using FileDBContext ctx = new FileDBContext();
            FileContext fileContext = new FileContext();
            var adults = fileContext.Adults;

            foreach (var adult in adults)
            {
                ctx.Adults.Add(adult);
            }

            ctx.SaveChanges();
        }


        //adding the users in the database
        public static void addUser()
        {
            using FileDBContext ctx = new FileDBContext();
            var users = new[]
            {
                new User() {UserName = "dorin", Password = "1234", Level = "user"},
                new User() {UserName = "admin", Password = "admin", Level = "admin"}
            };
            foreach (var user in users)
            {
                ctx.Users.Add(user);
            }

            ctx.SaveChanges();
        }
    }
}