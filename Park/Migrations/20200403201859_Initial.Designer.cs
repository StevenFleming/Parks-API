﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Park.Models;

namespace Park.Migrations
{
    [DbContext(typeof(ParkContext))]
    [Migration("20200403201859_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Park.National", b =>
                {
                    b.Property<int>("NationalID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("NationalID");

                    b.ToTable("Nationals");
                });

            modelBuilder.Entity("Park.State", b =>
                {
                    b.Property<int>("StateID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("StateID");

                    b.ToTable("States");
                });
#pragma warning restore 612, 618
        }
    }
}
