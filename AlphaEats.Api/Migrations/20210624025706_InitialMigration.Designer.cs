﻿// <auto-generated />
using AlphaEats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AlphaEats.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210624025706_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AlphaEats.Models.Cuisine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cuisines");
                });

            modelBuilder.Entity("AlphaEats.Models.Restaurant", b =>
                {
                    b.Property<int>("CuisineId")
                        .HasColumnType("integer");

                    b.Property<string>("CuisineName")
                        .HasColumnType("text");

                    b.Property<int>("CustomerRating")
                        .HasColumnType("integer");

                    b.Property<int>("Distance")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
