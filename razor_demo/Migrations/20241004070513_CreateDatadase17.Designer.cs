﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using razor_demo.Data;

#nullable disable

namespace razor_demo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241004070513_CreateDatadase17")]
    partial class CreateDatadase17
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("razor_demo.Data.OfitActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("description")
                        .HasComment("Description");

                    b.Property<int?>("DisplayType")
                        .HasColumnType("integer")
                        .HasColumnName("display_type")
                        .HasComment("Display Type");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasComment("Actived");

                    b.Property<bool>("IsFarmerActivity")
                        .HasColumnType("boolean")
                        .HasColumnName("is_farmer_activity")
                        .HasComment("Is Farmer Activity");

                    b.Property<bool>("IsHarvesting")
                        .HasColumnType("boolean")
                        .HasColumnName("is_harvesting")
                        .HasComment("Is Harvesting");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<int?>("Sequence")
                        .HasColumnType("integer")
                        .HasColumnName("sequence")
                        .HasComment("Sequence");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.ToTable("ofit_activity", t =>
                        {
                            t.HasComment("Activity Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryType")
                        .HasColumnType("varchar")
                        .HasColumnName("category_type")
                        .HasComment("Category Type");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int?>("Depth")
                        .HasColumnType("integer")
                        .HasColumnName("depth")
                        .HasComment("Depth");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("description")
                        .HasComment("Description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasComment("Actived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer")
                        .HasColumnName("parent_id")
                        .HasComment("Parent");

                    b.Property<string>("ParentPath")
                        .HasColumnType("varchar")
                        .HasColumnName("parent_path")
                        .HasComment("Parent Path");

                    b.Property<int?>("Sequence")
                        .HasColumnType("integer")
                        .HasColumnName("sequence")
                        .HasComment("Sequence");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex(new[] { "ParentPath" }, "ofit_category_parent_path_index");

                    b.ToTable("ofit_category", t =>
                        {
                            t.HasComment("Category Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitCrop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id")
                        .HasComment("Category");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<string>("CropCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("crop_code")
                        .HasComment("Crop Code");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("description")
                        .HasComment("Description");

                    b.Property<string>("InternalCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("internal_code")
                        .HasComment("Internal Code");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasComment("Actived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ofit_crop", t =>
                        {
                            t.HasComment("Crop Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id")
                        .HasComment("Category");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("description")
                        .HasComment("Description");

                    b.Property<string>("InternalCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("internal_code")
                        .HasComment("Internal Code");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasComment("Actived");

                    b.Property<string>("MaterialCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("material_code")
                        .HasComment("Material Code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ofit_material", t =>
                        {
                            t.HasComment("Material Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitPartner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("varchar")
                        .HasColumnName("address")
                        .HasComment("Address");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id")
                        .HasComment("Category");

                    b.Property<string>("Comment")
                        .HasColumnType("varchar")
                        .HasColumnName("comment")
                        .HasComment("Comment");

                    b.Property<string>("Contact")
                        .HasColumnType("varchar")
                        .HasColumnName("contact")
                        .HasComment("Contact");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<string>("Email")
                        .HasColumnType("varchar")
                        .HasColumnName("email")
                        .HasComment("Email");

                    b.Property<string>("InternalCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("internal_code")
                        .HasComment("Internal Code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar")
                        .HasColumnName("phone")
                        .HasComment("Phone");

                    b.Property<string>("Website")
                        .HasColumnType("varchar")
                        .HasColumnName("website")
                        .HasComment("Website");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ofit_partner", t =>
                        {
                            t.HasComment("Partner Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id")
                        .HasComment("Category");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("description")
                        .HasComment("Description");

                    b.Property<string>("InternalCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("internal_code")
                        .HasComment("Internal Code");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasComment("Actived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ofit_product", t =>
                        {
                            t.HasComment("Product Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitTool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id")
                        .HasComment("Category");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("description")
                        .HasComment("Description");

                    b.Property<string>("InternalCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("internal_code")
                        .HasComment("Internal Code");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasComment("Actived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<string>("ToolCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("tool_code")
                        .HasComment("Tool Code");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ofit_tool", t =>
                        {
                            t.HasComment("Tool Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id")
                        .HasComment("Category");

                    b.Property<double?>("Convert")
                        .HasColumnType("double precision")
                        .HasColumnName("convert")
                        .HasComment("Convert");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<bool>("DefaultUnit")
                        .HasColumnType("boolean")
                        .HasColumnName("default_unit")
                        .HasComment("Default Unit");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("description")
                        .HasComment("Description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasComment("Actived");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name")
                        .HasComment("Name");

                    b.Property<string>("Notation")
                        .HasColumnType("varchar")
                        .HasColumnName("notation")
                        .HasComment("Notation");

                    b.Property<DateTime?>("WriteDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("write_date");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ofit_unit", t =>
                        {
                            t.HasComment("Unit Management");
                        });
                });

            modelBuilder.Entity("razor_demo.Data.OfitCategory", b =>
                {
                    b.HasOne("razor_demo.Data.OfitCategory", "CategoryParent")
                        .WithMany("CategoryChildrens")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("ofit_category_category_id_fkey");

                    b.Navigation("CategoryParent");
                });

            modelBuilder.Entity("razor_demo.Data.OfitCrop", b =>
                {
                    b.HasOne("razor_demo.Data.OfitCategory", "OfitCategory")
                        .WithMany("OfitCrops")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("ofit_tool_category_id_fkey");

                    b.Navigation("OfitCategory");
                });

            modelBuilder.Entity("razor_demo.Data.OfitMaterial", b =>
                {
                    b.HasOne("razor_demo.Data.OfitCategory", "OfitCategory")
                        .WithMany("OfitMaterials")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("ofit_material_category_id_fkey");

                    b.Navigation("OfitCategory");
                });

            modelBuilder.Entity("razor_demo.Data.OfitPartner", b =>
                {
                    b.HasOne("razor_demo.Data.OfitCategory", "OfitCategory")
                        .WithMany("OfitPartners")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("ofit_tool_category_id_fkey");

                    b.Navigation("OfitCategory");
                });

            modelBuilder.Entity("razor_demo.Data.OfitProduct", b =>
                {
                    b.HasOne("razor_demo.Data.OfitCategory", "OfitCategory")
                        .WithMany("OfitProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("ofit_tool_category_id_fkey");

                    b.Navigation("OfitCategory");
                });

            modelBuilder.Entity("razor_demo.Data.OfitTool", b =>
                {
                    b.HasOne("razor_demo.Data.OfitCategory", "OfitCategory")
                        .WithMany("OfitTools")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("ofit_tool_category_id_fkey");

                    b.Navigation("OfitCategory");
                });

            modelBuilder.Entity("razor_demo.Data.OfitUnit", b =>
                {
                    b.HasOne("razor_demo.Data.OfitCategory", "OfitCategory")
                        .WithMany("OfitUnits")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("ofit_tool_category_id_fkey");

                    b.Navigation("OfitCategory");
                });

            modelBuilder.Entity("razor_demo.Data.OfitCategory", b =>
                {
                    b.Navigation("CategoryChildrens");

                    b.Navigation("OfitCrops");

                    b.Navigation("OfitMaterials");

                    b.Navigation("OfitPartners");

                    b.Navigation("OfitProducts");

                    b.Navigation("OfitTools");

                    b.Navigation("OfitUnits");
                });
#pragma warning restore 612, 618
        }
    }
}
