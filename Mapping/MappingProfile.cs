using AutoMapper;
using CarProject.Controllers.Resources;
using CarProject.Models;

namespace CarProject.Mapping
{
    public class MappingProfile : Profile 
    {

        public MappingProfile()
        {
            CreateMap<Feature, FeatureResource>();
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            
        }
        
    }
}