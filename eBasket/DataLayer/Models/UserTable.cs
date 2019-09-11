using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Models
{
    public class UserTable : UserBoard
    {


        public override DTOUserBoard GetDTOUserBoard()
        {
            DTOUserTable dto = new DTOUserTable();
            return dto.GetById(this.Id);
        }
    }
}
