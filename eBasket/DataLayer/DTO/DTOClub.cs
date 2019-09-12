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
    public class DTOClub
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string State { get; set; }

        public DTOClub GetById(int id)
        {
            var club = db.Club.Find(id);
            return Mapper.Map<DTOClub>(club);
        }
    }
}
