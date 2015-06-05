using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipAirportAPI.ViewModels.AirportPersonel;
using DipAirportDOM;

namespace DipAirportAPI.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<AirportPersonel, AirportPersonelEdit>();
            AutoMapper.Mapper.CreateMap<AirportPersonel, AirportPersonelView>();
        }
    }
}
