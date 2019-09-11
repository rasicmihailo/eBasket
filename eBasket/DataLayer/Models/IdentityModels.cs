using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataLayer;
using DataLayer.Models;

namespace eBasket.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string LastName { get; set; }
        
        public UserType UserType { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserLevel UserLevel { get; set; }

        public int ClubId { get; set; }

        public string CoachId { get; set; }

        public int UserBoardId { get; set; }

        [ForeignKey("ClubId")]
        public virtual Club Club { get; set; }

        [ForeignKey("CoachId")]
        public virtual ApplicationUser Coach { get; set; }

        [ForeignKey("UserBoardId")]
        public virtual UserBoard UserBoard { get; set; }



        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("eBasketDatabase", throwIfV1Schema: false) { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Jersey> Jerseys { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<UserTraining> UserTrainings { get; set; }  

        public virtual DbSet<UserBoard> UserBoard { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }
        public virtual DbSet<UserShapeTable> UserShapeTable { get; set; }

    }
}