using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.DTO;

namespace DataLayer
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<UserBoard, DTOUserBoard>();
            CreateMap<UserShapeTable, DTOUserShapeTable>();
            CreateMap<UserTable, DTOUserTable>();
        }
    }
}
