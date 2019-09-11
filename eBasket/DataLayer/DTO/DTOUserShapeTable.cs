using eBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DataLayer.DTO
{
    [Serializable]
    public class DTOUserShapeTable : DTOUserBoard
    {
        public override DTOUserBoard GetById(int id)
        {
            var userShape = dbContext.UserShapeTable.Find(id);
            return Mapper.Map<DTOUserShapeTable>(userShape);
        }
    }
}
