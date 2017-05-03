using AutoMapper;
using CarProject.Controllers.Resources;
using CarProject.Models;
using System.Linq;

namespace CarProject.Mapping
{
    public class MappingProfile : Profile 
    {

        public MappingProfile()
        {

        
            // Mapping Domain Models to API resources
            CreateMap<Feature, FeatureResource>();
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Demo, DemoResource>();

            // Map API resource to Domain
            CreateMap<VehicleResource, Vehicle>()
                .ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.contactResource.Name))
                .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.contactResource.Email))
                .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.contactResource.Phone))
                .ForMember(v => v.Features, opt => opt.MapFrom(vr => vr.Features.Select(id => new VehicleFeature{ FeatureId = id })));
            
        }
        
    }
}