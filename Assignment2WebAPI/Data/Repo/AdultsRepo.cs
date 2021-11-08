using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment2WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;

using Models;

namespace Assignment2WebAPI.Data.Repo
{
    public class AdultsRepo:IAdult
    {
        private FileDBContext ctx;
        public AdultsRepo(FileDBContext ctx)
        {
            this.ctx = ctx;
        }
        
        public async Task<List<Adult>> GetAsync()
        {
            Console.WriteLine(ctx.Adults.ToListAsync().Result[0].FirstName +"lalalala");
            return await ctx.Adults.Include(a=>a.JobTitle).ToListAsync();
        }

        public async Task AddAsync(Adult adult)
        { 
            
            await ctx.Adults.AddAsync(adult);
            await ctx.SaveChangesAsync();
        }
    }
}