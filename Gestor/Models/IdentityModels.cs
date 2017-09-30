using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Gestor.Models
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
            : base("SqlServer", throwIfV1Schema: false)
        {
        }

        public DbSet<LogData> LogData { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProductTree> ProductTrees { get; set; }
        public DbSet<Process> Processos { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<ClasseCusto> ClassesCusto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Linha> Linhas { get; set; }
        public DbSet<GrupoRateio> GruposRateio { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}