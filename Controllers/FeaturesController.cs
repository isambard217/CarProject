using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarProject.Controllers.Resources;
using CarProject.Models;
using CarProject.persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarProject.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly CarDbContext context;

        private readonly IMapper mapper;

        public FeaturesController(CarDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }


        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
          
            var features = await context.Features.ToListAsync();
            
            
            return Mapper.Map<List<Feature>, List<FeatureResource>>(features);

        }

        

    }
}