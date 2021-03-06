﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Park.Models;

namespace Park.Migrations
{
    [DbContext(typeof(ParkContext))]
    [Migration("20200403212924_Locations")]
    partial class Locations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Park.National", b =>
                {
                    b.Property<int>("NationalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("NationalId");

                    b.ToTable("Nationals");
                });

            modelBuilder.Entity("Park.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("StateId");

                    b.ToTable("States");
                });
#pragma warning restore 612, 618
        }
    }
}
