using AutoMapper;
using eBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    [Serializable]
    public class DTOTraining
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int Id { get; set; }
        public int ActionId { get; set; }
        public Action Action { get; set; }
        public int CurrentTrainingID { get; set; }
        public DateTime TrainingDate { get; set; }
        public int ActionCheckpoint { get; set; }
        public TrainingStatus TrainingStatus { get; set; }


        public DTOTraining GetById(int id)
        {
            var training = db.Trainings.Find(id);
            return Mapper.Map<DTOTraining>(training);
        }
    }
}
