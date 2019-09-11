using eBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DataLayer.DTO
{
    [Serializable]
    public abstract class DTOUserBoard
    {
        protected ApplicationDbContext dbContext = new ApplicationDbContext();

        public int Id { get; set; }   
        public string Shape { get; set; }


        public abstract DTOUserBoard GetById(int id);
    }
}
