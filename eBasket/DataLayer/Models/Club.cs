using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace DataLayer.Models
{
    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(64)]
        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        public string State { get; set; }       
    }
}
