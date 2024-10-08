using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_demo.Data;

namespace razor_demo.Data
{
    public class AppDbContext : DbContext
    {
        internal readonly object T;

        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<razor_demo.Data.OfitCompany> OfitCompany { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitActivity> OfitActivity { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitCategory> OfitCategory { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitCrop> OfitCrop { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitMaterial> OfitMaterial { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitPartner> OfitPartner { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitProduct> OfitProduct { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitTool> OfitTool { get; set; } = default!;
        public DbSet<razor_demo.Data.OfitUnit> OfitUnit { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            modelBuilder.Entity<OfitCategory>(entity =>
            {

                entity.HasIndex(e => e.ParentPath, "ofit_category_parent_path_index");


                entity.HasOne(e => e.CategoryParent)
                      .WithMany(e => e.CategoryChildrens)
                      .HasForeignKey(e => e.ParentId)
                      .OnDelete(DeleteBehavior.Cascade) // Optional: Prevent cascading delete
                      .HasConstraintName("ofit_category_category_id_fkey");

                entity.Property(e => e.Type)
                      .HasConversion<string>();  // Store enum as a string in the database

                entity.HasOne(d => d.OfitCompany)
                    .WithMany(p => p.OfitCategories)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Restrict) // Optional: Prevent cascading delete
                    .HasConstraintName("ofit_tool_category_id_fkey");

            });

            modelBuilder.Entity<OfitMaterial>(entity =>
            {
               
                entity.HasOne(d => d.OfitCategory)
                    .WithMany(p => p.OfitMaterials)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade) // Optional: Prevent cascading delete
                    .HasConstraintName("ofit_material_category_id_fkey");

            });

            modelBuilder.Entity<OfitTool>(entity =>
            {
                entity.HasOne(d => d.OfitCategory)
                    .WithMany(p => p.OfitTools)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade) // Optional: Prevent cascading delete
                    .HasConstraintName("ofit_tool_category_id_fkey");
            });

            modelBuilder.Entity<OfitProduct>(entity =>
            {
                entity.HasOne(d => d.OfitCategory)
                    .WithMany(p => p.OfitProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade) // Optional: Prevent cascading delete
                    .HasConstraintName("ofit_tool_category_id_fkey");
            });

            modelBuilder.Entity<OfitUnit>(entity =>
            {
                entity.HasOne(d => d.OfitCategory)
                    .WithMany(p => p.OfitUnits)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade) // Optional: Prevent cascading delete
                    .HasConstraintName("ofit_tool_category_id_fkey");
            });

            modelBuilder.Entity<OfitCrop>(entity =>
            {
                entity.HasOne(d => d.OfitCategory)
                    .WithMany(p => p.OfitCrops)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade) // Optional: Prevent cascading delete
                    .HasConstraintName("ofit_tool_category_id_fkey");
            });

            modelBuilder.Entity<OfitPartner>(entity =>
            {
                entity.HasOne(d => d.OfitCategory)
                    .WithMany(p => p.OfitPartners)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade) // Optional: Prevent cascading delete
                    .HasConstraintName("ofit_tool_category_id_fkey");
            });

        }

    }


}
