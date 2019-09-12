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
    public class DTOAction
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }

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

        public DTOAction GetById(int id)
        {
            var action = db.Actions.Find(id);
            return Mapper.Map<DTOAction>(action);
        }
    }
}
