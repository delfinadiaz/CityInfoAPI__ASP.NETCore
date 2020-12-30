using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDTO>();
            CreateMap<Models.PointOfInterestForCreationDTO, Entities.PointOfInterest>();
            CreateMap<Models.PointOfInterestForUpdateDTO, Entities.PointOfInterest>()
                .ReverseMap();

        }
    }
}
