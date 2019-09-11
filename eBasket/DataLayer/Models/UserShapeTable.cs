using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using DataLayer.DTO;

namespace DataLayer.Models
{
    public class UserShapeTable : UserBoard
    {


        public override DTOUserBoard GetDTOUserBoard()
        {
            DTOUserShapeTable dto = new DTOUserShapeTable();
            return dto.GetById(this.Id);
        }

    }
}
