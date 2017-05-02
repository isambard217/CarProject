using System;
using System.Threading.Tasks;
using AutoMapper;
using CarProject.Controllers.Resources;
using CarProject.Models;
using CarProject.persistance;
using Microsoft.AspNetCore.Mvc;

namespace CarProject.Controllers
{

    [Route("/api/vehicles")]
    public class VehiclesController : Controller 
    {
        //Properties
        private readonly CarDbContext context;

        private readonly IMapper mapper;
        

        //Constructor      
        public VehiclesController(IMapper mapper, CarDbContext context)
        {
            this.mapper = mapper;
            this.context = context;

        }

      /*  [HttpGet("/")]
        public string Vehiclemach()
        {


            return "";
        }*/

        [HttpGet("vehicles/new")]
        public async Task<IActionResult> CreateVehicle([FromBody]VehicleResource vehicleResource)
        {      

                var date = DateTime.Now;

                var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);

                context.Vehicles.Add(vehicle);

                await context.SaveChangesAsync();

                return Ok(vehicle);

         }


         [HttpPut("{id}")] // /api/vehicles/{id}
         public async Task<IActionResult> UpdateVehicle(int id, [FromBody] VehicleResource vehicleResource) // Because we have a parameter in the route called id we also need one in the parameter aswell
         {

           if(!ModelState.IsValid)
                return BadRequest(ModelState);

            mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            //vehicle.LastUpdate = DateTime.Now();

            return new ViewResult();

         }

         // Other methods
         /* 
         [HttpPost]
         public async Task<IActionResult> CdreateVehicle([FromBody]VehicleResource vehicleResource)
         {      

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                

                //var model = await context.Vehicles.FindAsync(vehicleResource.ModelId);

                // The IMapper is used to map complicated C# code to simple Javascript objects
                // Create a Vehicle object from the VehicleResource
             
                var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);  

                //return new OkObjectResult("Object is empty");                 
        
                vehicle.LastUpdate = DateTime.Now;
                context.Vehicles.Add(vehicle);
                await context.SaveChangesAsync();

                var result = GetResult(vehicle);

                return Ok(result);
                
        }
        */

        private VehicleResource GetResult(Vehicle vehicle)
        {
            
            return mapper.Map<Vehicle, VehicleResource>(vehicle);
        }




        ///api/vehicles/makes
        /*[HttpGet]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {

            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return Mapper.Map<List<Make>, List<MakeResource>>(makes);

        }
          */

    }
}