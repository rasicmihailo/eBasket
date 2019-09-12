using AutoMapper;
using DataLayer.Models;
using eBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    [Serializable]
    public class DTOUserTraining
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int Id { get; set; }
        public string UserId { get; set; }
        public int TrainingId { get; set; }
        public ApplicationUser User { get; set; }
        public Training Training { get; set; }

        public double Accuracy { get; set; }

        public DTOUserTraining GetById(int id)
        {
            var userTraining = db.UserTrainings.Find(id);
            return Mapper.Map<DTOUserTraining>(userTraining);
        }
    }
}
