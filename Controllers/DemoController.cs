using System.Collections.Generic;
using System.Threading.Tasks;
using CarProject.persistance;
using Microsoft.AspNetCore.Mvc;
using CarProject.Controllers.Resources;
using CarProject.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace CarProject.Controllers
{
    public class DemoController : Controller
    {


        private readonly CarDbContext context;

        private readonly IMapper mapper;

        public DemoController(IMapper mapper, CarDbContext context)
        {

            this.context = context;
            this.mapper = mapper;

        }

        [HttpGet("/api/demo")]
        public async Task<IEnumerable<DemoResource>> GetDemo()
        {

            //var demos = await context.Demos.FindAsync(1);
            var demos = await context.Demos.ToListAsync();

            return Mapper.Map<List<Demo>, List<DemoResource>>(demos);

        }


    }
}