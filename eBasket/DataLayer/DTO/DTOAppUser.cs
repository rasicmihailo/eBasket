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
    public class DTOAppUser
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserLevel UserLevel { get; set; }
        public int ClubId { get; set; }
        public string CoachId { get; set; }
        public int UserBoardId { get; set; }
        public Club Club { get; set; }
        public ApplicationUser Coach { get; set; }
        public UserBoard UserBoard { get; set; }


        public DTOAppUser GetById(string id)
        {
            var user = db.Users.Find(id);
            return Mapper.Map<DTOAppUser>(user);
        }
    }
}
