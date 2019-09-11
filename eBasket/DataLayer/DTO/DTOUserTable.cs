using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.DTO
{
    [Serializable]
    public class DTOUserTable : DTOUserBoard
    {
        public override DTOUserBoard GetById(int id)
        {
            var table = dbContext.UserTable.Find(id);
            return Mapper.Map<DTOUserTable>(table);
        }
    }
}
