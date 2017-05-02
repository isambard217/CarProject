using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarProject.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int Id { get; set; }

        // The reason we have two objects is because it is easier to persist an object 
        // when we persist we don't have to persist an entire Model object, instead
        // we can persist only the id as an identifier

        [ForeignKey("Model")]
        public int ModelId { get; set; }

        public Model Model { get; set; }

        public bool IsRegistered { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string ContactEmail { get; set; }

        [StringLength(255)]
        public string ContactPhone { get; set; }

        public DateTime LastUpdate { get; set; }

       public ICollection<VehicleFeature> Features { get; set; }


        public Vehicle()
        {

            Features = new Collection<VehicleFeature>();

        }
    }
}