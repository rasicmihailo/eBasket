using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Models
{
    public class UserBoard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Shape { get; set; }


        public virtual DTOUserBoard GetDTOUserBoard()
        {
            return null;
        }
    }
}
