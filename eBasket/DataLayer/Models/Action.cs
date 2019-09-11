using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Models
{
    public class Action
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(64)]
        [Required]
        public string Name { get; set; }

        public int ClubId { get; set; }

        [ForeignKey("ClubId")]
        public virtual Club Club { get; set; }

        //1
        public double PG_X { get; set; }
        public double PG_Y { get; set; }
        //2
        public double SG_X { get; set; }
        public double SG_Y { get; set; }
        //3
        public double SF_X { get; set; }
        public double SF_Y { get; set; }
        //4
        public double PF_X { get; set; }
        public double PF_Y { get; set; }
        //5
        public double C_X { get; set; }
        public double C_Y { get; set; }

    }
}
