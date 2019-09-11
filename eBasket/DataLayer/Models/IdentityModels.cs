using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace eBasket.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {


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
            : base("BazaAtomac", throwIfV1Schema: false) { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public virtual DbSet<AFigure> AFigures { get; set; }
        //public virtual DbSet<ATable> ATable { get; set; }
        //public virtual DbSet<Game> Games { get; set; }
        //public virtual DbSet<Message> Messages { get; set; }
        //public virtual DbSet<Move> Moves { get; set; }
        //public virtual DbSet<Rules> Ruless { get; set; }
        //public virtual DbSet<Team> Teams { get; set; }
        //public virtual DbSet<Stuff> Stuffs { get; set; }

        //public DbSet<Artifact> Artifacts { get; set; }
    }
}