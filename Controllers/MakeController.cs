using System.Collections.Generic;
using System.Threading.Tasks;
using asp_core_angular.Models;
using asp_core_angular.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_core_angular.Controllers
{
    public class MakeController : Controller
    {
        private readonly VDBContext dBContext;
        public MakeController(VDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await dBContext.Makes.Include(m => m.Models).ToArrayAsync();
        }
    }
}