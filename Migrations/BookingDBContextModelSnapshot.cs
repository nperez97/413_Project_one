﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _413_Project_one.Models;

namespace _413_Project_one.Migrations
{
    [DbContext(typeof(BookingDBContext))]
    partial class BookingDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("_413_Project_one.Models.AppointmentModel", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointmentStartTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Booked")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppointmentID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("_413_Project_one.Models.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GroupAppointmentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupContactEmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupContactPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.HasKey("GroupID");

                    b.ToTable("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
