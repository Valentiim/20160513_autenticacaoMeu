using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {   [Display(Name ="Nome Próprio")]
        public string NomeProprio { get; set; }
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }
        [Display(Name = "NIF")]
        public string NIF { get; set; }
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
        //construtor - serve para referenciar a BD
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        //instruções para criar as tabelas, dentro da BD
        public virtual DbSet<Consultas> Consultas { get; set; }
        public virtual DbSet<Donos> Donos { get; set; }
        public virtual DbSet<Veterinarios> Veterinarios { get; set; }
        public virtual DbSet<Animais> Animais { get; set; }

    }//Fim da classe
}