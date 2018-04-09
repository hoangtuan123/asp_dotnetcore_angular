using System.Collections.Generic;
using System.Threading.Tasks;
using asp_core_angular.Models;
using asp_core_angular.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using asp_core_angular.Controllers.Resources;

namespace asp_core_angular.Controllers
{
    public class MakeController : Controller
    {
        private readonly VDBContext dBContext;
        private IMapper mapper;
        public MakeController(VDBContext dBContext, IMapper mapper)
        {
            this.dBContext = dBContext;
            this.mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await dBContext.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);

        }
    }
}