﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(SkiResContext))]
    [Migration("20231101083014_validation")]
    partial class validation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.ClientSpace.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ClientProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("DataAccess.Models.ClientSpace.ClientProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("ClientProfiles");
                });

            modelBuilder.Entity("DataAccess.Models.ClientSpace.ClientPromotion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientPromotions");
                });

            modelBuilder.Entity("DataAccess.Models.HotelSpace.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("DataAccess.Models.HotelSpace.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BedsNum")
                        .HasColumnType("int");

                    b.Property<Guid>("ClientRoomReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("DataAccess.Models.Intermediate.ClientRoomReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.ToTable("ClientRoomReservations");
                });

            modelBuilder.Entity("DataAccess.Models.Intermediate.ClientSkiPass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ActivationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SkiPassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientSkiPasses");
                });

            modelBuilder.Entity("DataAccess.Models.Intermediate.SlopeLift", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LiftId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlopeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LiftId");

                    b.HasIndex("SlopeId");

                    b.ToTable("SlopeLift");
                });

            modelBuilder.Entity("DataAccess.Models.SkiPassSpace.SkiPass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PassType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("WorkingHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SkiPass");
                });

            modelBuilder.Entity("DataAccess.Models.SlopeSpace.Lift", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Lift");
                });

            modelBuilder.Entity("DataAccess.Models.SlopeSpace.Slope", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DificultyLevel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Slope");
                });

            modelBuilder.Entity("DataAccess.Models.ClientSpace.ClientProfile", b =>
                {
                    b.HasOne("DataAccess.Models.ClientSpace.Client", "Client")
                        .WithOne("ClientProfile")
                        .HasForeignKey("DataAccess.Models.ClientSpace.ClientProfile", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DataAccess.Models.ClientSpace.ClientPromotion", b =>
                {
                    b.HasOne("DataAccess.Models.ClientSpace.Client", "Client")
                        .WithMany("ClientPromotions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DataAccess.Models.HotelSpace.Room", b =>
                {
                    b.HasOne("DataAccess.Models.HotelSpace.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("DataAccess.Models.Intermediate.ClientRoomReservation", b =>
                {
                    b.HasOne("DataAccess.Models.ClientSpace.Client", "Client")
                        .WithMany("ClientRoomReservations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.HotelSpace.Room", "Room")
                        .WithOne("ClientRoomReservation")
                        .HasForeignKey("DataAccess.Models.Intermediate.ClientRoomReservation", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DataAccess.Models.Intermediate.ClientSkiPass", b =>
                {
                    b.HasOne("DataAccess.Models.ClientSpace.Client", "Client")
                        .WithMany("ClientSkiPasses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.SkiPassSpace.SkiPass", "SkiPass")
                        .WithMany("ClientSkiPasses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("SkiPass");
                });

            modelBuilder.Entity("DataAccess.Models.Intermediate.SlopeLift", b =>
                {
                    b.HasOne("DataAccess.Models.SlopeSpace.Lift", "Lift")
                        .WithMany("SlopeLifts")
                        .HasForeignKey("LiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.SlopeSpace.Slope", "Slope")
                        .WithMany("SlopeLifts")
                        .HasForeignKey("SlopeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lift");

                    b.Navigation("Slope");
                });

            modelBuilder.Entity("DataAccess.Models.ClientSpace.Client", b =>
                {
                    b.Navigation("ClientProfile")
                        .IsRequired();

                    b.Navigation("ClientPromotions");

                    b.Navigation("ClientRoomReservations");

                    b.Navigation("ClientSkiPasses");
                });

            modelBuilder.Entity("DataAccess.Models.HotelSpace.Hotel", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DataAccess.Models.HotelSpace.Room", b =>
                {
                    b.Navigation("ClientRoomReservation")
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.SkiPassSpace.SkiPass", b =>
                {
                    b.Navigation("ClientSkiPasses");
                });

            modelBuilder.Entity("DataAccess.Models.SlopeSpace.Lift", b =>
                {
                    b.Navigation("SlopeLifts");
                });

            modelBuilder.Entity("DataAccess.Models.SlopeSpace.Slope", b =>
                {
                    b.Navigation("SlopeLifts");
                });
#pragma warning restore 612, 618
        }
    }
}
