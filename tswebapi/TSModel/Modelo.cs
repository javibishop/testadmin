using Microsoft.EntityFrameworkCore;
using TSModel.Dominio;

namespace TSModel
{
    public class Modelo : DbContext
    {
        public DbSet<TsAdmin> Admins { get; set; }
        public DbSet<TsRole> Roles { get; set; }
        public DbSet<TsAdminMenu> AdminMenus { get; set; }
        public DbSet<TsMenu> Menus { get; set; }
        public DbSet<TsAdminRole> AdminRoles { get; set; }
        public DbSet<Dominio.Usuaria> Usuarias { get; set; }

        //public DbSet<Dominio.Usuaria> Usuarias { get; set; }
        //public DbSet<Dominio.Usuaria> Usuarias { get; set; }
        //public DbSet<Dominio.Usuaria> Usuarias { get; set; }


        public Modelo(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseMySQL("server=localhost;port=3306;database=ts;uid=root;password=mysql;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TsAdmin>(entity =>
            {
                entity.Property(m => m.Username).HasMaxLength(10);
                entity.Property(m => m.Password).HasMaxLength(20);
            });

            modelBuilder.Entity<TsAdminRole>(entity =>
            {
                entity.HasKey(am => new { am.AdminId, am.RoleId });
                entity.HasOne(am => am.Admin).WithMany(a => a.AdminRoles).HasForeignKey(am => am.AdminId);
                entity.HasOne(am => am.Role).WithMany(m => m.AdminRoles).HasForeignKey(am => am.RoleId);
            });

            modelBuilder.Entity<TsAdminMenu>(entity =>
            {
                entity.HasKey(am => new { am.AdminId, am.MenuId });
                entity.HasOne(am => am.Admin).WithMany(a => a.AdminMenus).HasForeignKey(am => am.AdminId);
                entity.HasOne(am => am.Menu).WithMany(m => m.AdminMenus).HasForeignKey(am => am.MenuId);
            });

            // Shorten key length for Identity

            //http://ltuttini.blogspot.com/2013/08/entity-frameworkcode-first-herencia.html

            //modelBuilder.Entity<Persona>(entity => {
            //    entity.HasKey(m => m.Id);
            //    entity.Property(m => m.Apellido).HasMaxLength(200).IsRequired(true);
            //    entity.Property(m => m.Nombre).HasMaxLength(250).IsRequired(true);
            //    entity.Property(m => m.Edad).IsRequired(true);
            //    entity.Property(m => m.FechaNacimiento).IsRequired(true);
            //    entity.Property(m => m.NacionalidadId).IsRequired(true);
            //    entity.Property(m => m.Telefono).HasMaxLength(60).IsRequired(false);
            //    entity.Property(m => m.Direccion).HasMaxLength(300).IsRequired(false);
            //    entity.Property(e => e.Discriminator).IsRequired();
            //    entity.ToTable("Personas");
            //});

            //modelBuilder.Entity<Usuaria>(entity =>
            //{
            //    entity.HasKey(m => m.Id);
            //    entity.Property(m => m.UsuarioCentroSalud).IsRequired(true);
            //    entity.Property(m => m.ParejaConViviente).IsRequired(true);
            //    entity.Property(m => m.UsuarioCentroSalud).IsRequired(true);
            //    entity.Property(m => m.SinPareja).IsRequired(true);
            //    entity.Property(m => m.ConocePorConocido).IsRequired(true);
            //    entity.Property(m => m.ConocePorUS).IsRequired(true);
            //    entity.Property(m => m.ConocePorOrganizacion).IsRequired(true);
            //    entity.Property(m => m.ConocePorMedios).IsRequired(true);
            //    entity.Property(m => m.ConocePorUsuarioConcejeria).IsRequired(true);
            //    entity.Property(m => m.ConocePorInsititucionSalud).IsRequired(true);
            //    entity.Property(m => m.ConocePorInsititucionSaludObs).HasMaxLength(500).IsRequired(false);
            //    entity.Property(m => m.ConocePorOtro).HasMaxLength(500).IsRequired(false);
            //    entity.Property(m => m.NivelInstruccion).IsRequired(true);
            //    entity.Property(m => m.NivelInstruccionEstado).IsRequired(true);
            //    entity.ToTable("Usuarias");
            //});

            //modelBuilder.Entity<Usuaria>().HasBaseType<Persona>();

            //https://docs.microsoft.com/en-us/ef/core/modeling/inheritance
            //http://www.entityframeworktutorial.net/code-first/database-initialization-in-code-first.aspx

            //modelBuilder.Entity<IdentityRole>(entity => {
            //    entity.Property(m => m.Name).HasMaxLength(127);
            //    entity.Property(m => m.NormalizedName).HasMaxLength(127);
            //});
            //modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            //{
            //    entity.Property(m => m.LoginProvider).HasMaxLength(127);
            //    entity.Property(m => m.ProviderKey).HasMaxLength(127);
            //});
            //modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            //{
            //    entity.Property(m => m.UserId).HasMaxLength(127);
            //    entity.Property(m => m.RoleId).HasMaxLength(127);
            //});
            //modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            //{
            //    entity.Property(m => m.UserId).HasMaxLength(127);
            //    entity.Property(m => m.LoginProvider).HasMaxLength(127);
            //    entity.Property(m => m.Name).HasMaxLength(127);

            //});
            //modelBuilder.Entity<ProductCategory>()
            //    .HasKey(x => new { x.ProductId, x.CategoryId });

            //modelBuilder.Entity<DataTypesVariable>(eb =>
            //{
            //    // Need to specify the type until EF#12212 is fixed
            //    eb.Property(e => e.TypeJsonArray).HasColumnType("json");
            //    eb.Property(e => e.TypeJsonArrayN).HasColumnType("json");
            //    eb.Property(e => e.TypeJsonObject).HasColumnType("json");
            //    eb.Property(e => e.TypeJsonObjectN).HasColumnType("json");
            //});

            //modelBuilder.Entity<GeneratedContact>(eb =>
            //{
            //    // Need to specify the type until EF#12212 is fixed
            //    eb.Property(e => e.Names).HasColumnType("json");
            //    eb.Property(e => e.ContactInfo).HasColumnType("json");
            //});

            // Add our models fluent APIs
            //ModeloMeta.OnModelCreating(modelBuilder);
            //GeneratedContactMeta.OnModelCreating(modelBuilder);
            //PeopleMeta.OnModelCreating(modelBuilder);

            //if (AppConfig.EfSchema != null)
            //{
            //    // Generates all models in a different schema
            //    modelBuilder.HasDefaultSchema(AppConfig.EfSchema);
            //}

        }


    }
}
