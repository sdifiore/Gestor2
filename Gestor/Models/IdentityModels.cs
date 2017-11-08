﻿using System.Data.Entity;
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

        public DbSet<Ajuste> Ajustes { get; set; }
        public DbSet<AjusteProduto> AjusteProdutos { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ClasseCusto> ClassesCusto { get; set; }
        public DbSet<Comum> Comuns { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }
        public DbSet<CustoFolha> CustoFolhas { get; set; }
        public DbSet<CustoInsumo> CustoInsumos { get; set; }
        public DbSet<Dominio> Dominios { get; set; }
        public DbSet<Embalagem> Embalagens { get; set; }
        public DbSet<EncapTubo> EncapTuboes { get; set; }
        public DbSet<Estrutura> Estruturas { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Finalidade> Finalidades { get; set; }
        public DbSet<Frete> Fretes { get; set; }
        public DbSet<Graxa> Graxas { get; set; }
        public DbSet<GrupoRateio> GruposRateio { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<Linha> Linhas { get; set; }
        public DbSet<LogData> LogData { get; set; }
        public DbSet<MedidaFita> MedidaFitas { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<ParmGraxa> ParmGraxas { get; set; }
        public DbSet<Pcp> Pcps { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<QtdEmbalagem> QtdEmbalagems { get; set; }
        public DbSet<QtdMaquinas> QtdMaquinas { get; set; }
        public DbSet<Rateio> Rateios { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<Resina> Resinas { get; set; }
        public DbSet<Sequencia> Sequencias { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Sucata> Sucatas { get; set; }
        public DbSet<TipoProducao> TiposProducao { get; set; }
        public DbSet<TipoAlteracao> TiposAlteracao { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<TotalParmGraxa> TotalParmGraxas { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}