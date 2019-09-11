using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Models
{
    public class Training
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ActionId { get; set; }

        [ForeignKey("ActionId")]
        public virtual Action Action { get; set; }

        public int CurrentTrainingID { get; set; }

        public DateTime TrainingDate { get; set; }

        public int ActionCheckpoint { get; set; }

        public TrainingStatus TrainingStatus { get; set; }
    }
}
