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
    [Migration("20241003093951_CreateDatadase9")]
    partial class CreateDatadase9
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

                    b.Property<bool>("t_Active")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ofit_activity", t =>
                        {
                            t.HasComment("Activity Management");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}