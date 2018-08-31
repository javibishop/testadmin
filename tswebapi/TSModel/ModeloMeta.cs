using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TSModel
{
    public static class ModeloMeta
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TsAdmin>(entity =>
            //{
            //    entity.Property(m => m.Username)
            //        .HasMaxLength(10);

            //    entity.Property(m => m.Password)
            //        .HasMaxLength(20);
            //});

            //modelBuilder.Entity<TsAdminRole>(entity =>
            //{
            //    entity.HasKey(am => new { am.AdminId, am.RoleId });

            //    entity.HasOne(am => am.Admin)
            //        .WithMany(a => a.AdminRoles)
            //        .HasForeignKey(am => am.AdminId);

            //    entity.HasOne(am => am.Role)
            //        .WithMany(m => m.AdminRoles)
            //        .HasForeignKey(am => am.RoleId);
            //});

            //modelBuilder.Entity<TsAdminMenu>(entity =>
            //{
            //    entity.HasKey(am => new { am.AdminId, am.MenuId });

            //    entity.HasOne(am => am.Admin)
            //        .WithMany(a => a.AdminMenus)
            //        .HasForeignKey(am => am.AdminId);

            //    entity.HasOne(am => am.Menu)
            //        .WithMany(m => m.AdminMenus)
            //        .HasForeignKey(am => am.MenuId);
            //});

        }
    }

    
}

