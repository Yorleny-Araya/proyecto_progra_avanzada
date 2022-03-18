using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using data = BE.DAL.DO.Objetos;

namespace BE.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<data.Autenticacion, DataModels.Autenticacion>().ReverseMap();
            CreateMap<data.Asistencia, DataModels.Asistencia>().ReverseMap();
            CreateMap<data.Ausencia, DataModels.Ausencia>().ReverseMap();
            CreateMap<data.BitacotaAccion, DataModels.BitacotaAccion>().ReverseMap();
            CreateMap<data.BitacotaSesion, DataModels.BitacotaSesion>().ReverseMap();
            CreateMap<data.Empleado, DataModels.Empleado>().ReverseMap();
        }
    }
}
