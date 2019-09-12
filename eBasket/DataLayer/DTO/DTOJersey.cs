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
    public class DTOJersey
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int Id { get; set; }
        public JerseyTop JerseyTop { get; set; }
        public string ColorTop { get; set; }
        public string ColorDown { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }

        public DTOJersey GetById(int id)
        {
            var jersey = db.Jerseys.Find(id);
            return Mapper.Map<DTOJersey>(jersey);
        }
    }
}
