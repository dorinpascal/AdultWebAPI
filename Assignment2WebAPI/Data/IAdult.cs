using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment2WebAPI.Data
{
    public interface IAdult
    {
        Task<List<Adult>> GetAsync();
        Task AddAsync(Adult adult);
    }
}