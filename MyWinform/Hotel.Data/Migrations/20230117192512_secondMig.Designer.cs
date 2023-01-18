﻿// <auto-generated />
using System;
using Hotel_Data.ProgramDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hotel.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230117192512_secondMig")]
    partial class secondMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hotel_Domain.Models.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookingDay")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("RoomId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("numeric");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Hotel_Domain.Models.Rooms.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Number")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("numeric");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hotel_Domain.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hotel_Domain.Models.Orders.Order", b =>
                {
                    b.HasOne("Hotel_Domain.Models.Rooms.Room", "Room")
                        .WithOne("Order")
                        .HasForeignKey("Hotel_Domain.Models.Orders.Order", "RoomId");

                    b.HasOne("Hotel_Domain.Models.Users.User", "User")
                        .WithOne("Order")
                        .HasForeignKey("Hotel_Domain.Models.Orders.Order", "UserId");

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hotel_Domain.Models.Rooms.Room", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Hotel_Domain.Models.Users.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
