﻿// <auto-generated />
using ExpanseTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExpanseTracker.Migrations
{
    [DbContext(typeof(ExpanseTrackerContext))]
    [Migration("20230712090805_AddCategoriesTable")]
    partial class AddCategoriesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExpanseTracker.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Food"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Travel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Entertainment"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Education"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 6,
                            Name = "House"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
