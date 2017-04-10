using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarProject.Models;
using CarProject.persistance;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;
using CarProject.Controllers.Resources;

namespace CarProject.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarDbContext context;

        private readonly IMapper mapper;

        public MakesController(CarDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }


        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {

            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return Mapper.Map<List<Make>, List<MakeResource>>(makes);

        }

    }
}