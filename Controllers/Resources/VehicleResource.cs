using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CarProject.Controllers.Resources
{

    // Because this is a Vehicle Resource it is best to data-annotations 
    // as the validation type
    public class VehicleResource
    {

        
        public int Id { get; set; }

        public int ModelId { get; set; }

        public bool IsRegistered { get; set; }

        public ContactResource contactResource { get; set; }

        public ICollection<int> Features {get; set;}

        public VehicleResource()
        {
            Features = new Collection<int>();
        }
        
    }
}