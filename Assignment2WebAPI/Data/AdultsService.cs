using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assignment2WebAPI.Persistence;
using Models;


namespace Assignment2WebAPI.Data
{
    public class AdultsService:IAdult
    {
        private FileContext fileContext = new FileContext();
        
        
        
        public async Task<List<Adult>> GetAsync()
        {
            return fileContext.Adults.ToList();
        }

       

        public async  Task AddAsync(Adult adult)
        {
            int max = fileContext.Adults.Max(m => m.Id);
            adult.Id = (++max);
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
            Console.WriteLine(adult.FirstName +" added with success");
        }
        
    }
}