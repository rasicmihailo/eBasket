using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Models
{
    public class Jersey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public JerseyTop JerseyTop { get; set; }

        public string ColorTop { get; set; }
            
        public string ColorDown { get; set; }

        public int ClubId { get; set; }

        [ForeignKey("ClubId")]
        public virtual Club Club { get; set; }
    }
}
