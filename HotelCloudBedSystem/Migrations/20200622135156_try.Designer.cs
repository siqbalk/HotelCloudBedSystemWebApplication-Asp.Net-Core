﻿// <auto-generated />
using System;
using HotelCloudBedSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelCloudBedSystem.Migrations
{
    [DbContext(typeof(HotelCloudDbContext))]
    [Migration("20200622135156_try")]
    partial class @try
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelCloudBedSystem.Models.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Aboutyou")
                        .HasMaxLength(2000);

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("AccountStatus");

                    b.Property<string>("Address");

                    b.Property<string>("AppRoleId");

                    b.Property<byte[]>("AvatarImage");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<bool>("IsEnable");

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<bool>("RequestAccept");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.CityMapLocation", b =>
                {
                    b.Property<int>("CityMapLocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.Property<string>("Latitude");

                    b.Property<string>("longtitude");

                    b.HasKey("CityMapLocationId");

                    b.ToTable("CityMapLocation");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutHotel");

                    b.Property<string>("Address");

                    b.Property<string>("AppUserId");

                    b.Property<string>("Description");

                    b.Property<string>("HotelCity");

                    b.Property<byte[]>("HotelImage");

                    b.Property<string>("HotelName");

                    b.Property<int>("NoOfFloors");

                    b.Property<int>("NoOfRooms");

                    b.Property<int>("ZipCode");

                    b.HasKey("HotelId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelFacilities", b =>
                {
                    b.Property<int>("HotelFacilitiesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AttachedWashrooms");

                    b.Property<bool>("BreckFast");

                    b.Property<bool>("CarParking");

                    b.Property<bool>("Dinner");

                    b.Property<bool>("FreeWifi");

                    b.Property<int?>("HotelId");

                    b.Property<bool>("Laundry");

                    b.Property<bool>("Lunch");

                    b.Property<bool>("Receptionservices");

                    b.HasKey("HotelFacilitiesId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelFacilities");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelFloors", b =>
                {
                    b.Property<int>("HotelFloorsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FloorName");

                    b.Property<int>("FloorNo");

                    b.Property<int?>("HotelId");

                    b.Property<int>("NoOfRooms");

                    b.HasKey("HotelFloorsId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelFloors");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelImages", b =>
                {
                    b.Property<int>("HotelImagesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("HImage");

                    b.Property<int?>("HotelId");

                    b.HasKey("HotelImagesId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelImages");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelMapLocation", b =>
                {
                    b.Property<int>("HotelMapLocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityMapLocationId");

                    b.Property<string>("HotelName");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.HasKey("HotelMapLocationId");

                    b.HasIndex("CityMapLocationId");

                    b.ToTable("HotelMapLocation");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelReview", b =>
                {
                    b.Property<int>("HotelReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HotelId");

                    b.Property<string>("Review");

                    b.Property<int>("ReviewStar");

                    b.Property<string>("UserName");

                    b.HasKey("HotelReviewId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelReview");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelRoomId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<int?>("HotelFloorsId");

                    b.Property<int?>("HotelId");

                    b.Property<int?>("HotelRoomTypeId");

                    b.Property<bool>("IsBooked");

                    b.Property<int>("OcupancyLimit");

                    b.Property<byte[]>("RoomImage");

                    b.Property<string>("RoomName");

                    b.Property<int>("RoomNo");

                    b.Property<int>("RsPernight");

                    b.HasKey("HotelRoomId");

                    b.HasIndex("HotelFloorsId");

                    b.HasIndex("HotelId");

                    b.HasIndex("HotelRoomTypeId");

                    b.ToTable("HotelRoom");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelRoomType", b =>
                {
                    b.Property<int>("HotelRoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoomType");

                    b.HasKey("HotelRoomTypeId");

                    b.ToTable("HotelRoomType");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("HotelRoomId");

                    b.Property<string>("PaymentType");

                    b.Property<int?>("RoomReservationId");

                    b.HasKey("PaymentId");

                    b.HasIndex("HotelRoomId");

                    b.HasIndex("RoomReservationId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomFacilities", b =>
                {
                    b.Property<int>("RoomFacilitiesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ac");

                    b.Property<bool>("AttachedWashRoom");

                    b.Property<int?>("HotelRoomId");

                    b.Property<bool>("Internet");

                    b.Property<bool>("Tv");

                    b.HasKey("RoomFacilitiesId");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("RoomFacilities");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomReservation", b =>
                {
                    b.Property<int>("RoomReservationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("AppUserId");

                    b.Property<DateTime>("ChkIndate");

                    b.Property<DateTime>("ChkOutdate");

                    b.Property<string>("Cnic");

                    b.Property<string>("Email");

                    b.Property<int?>("HotelRoomId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsPaymentSuccessfull");

                    b.Property<int>("NoOfNight");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("UserCity");

                    b.Property<string>("UserName");

                    b.Property<int>("ZipCode");

                    b.HasKey("RoomReservationId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("RoomReservation");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomReview", b =>
                {
                    b.Property<int>("RoomReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HotelRoomId");

                    b.Property<string>("Review");

                    b.Property<int>("ReviewStar");

                    b.Property<string>("UserName");

                    b.HasKey("RoomReviewId");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("RoomReview");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomsImage", b =>
                {
                    b.Property<int>("RoomsImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HotelRoomId");

                    b.Property<byte[]>("images");

                    b.HasKey("RoomsImageId");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("RoomsImage");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.StarRating", b =>
                {
                    b.Property<int>("StarRatingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StarName");

                    b.Property<int>("StarNo");

                    b.HasKey("StarRatingId");

                    b.ToTable("StarRating");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.TemporaryRoomType", b =>
                {
                    b.Property<int>("TemporaryRoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HotelId");

                    b.Property<int?>("HotelRoomTypeId");

                    b.HasKey("TemporaryRoomTypeId");

                    b.HasIndex("HotelId");

                    b.HasIndex("HotelRoomTypeId");

                    b.ToTable("TemporaryRoomType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.AppUser", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppRole", "AppRole")
                        .WithMany()
                        .HasForeignKey("AppRoleId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.Hotel", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelFacilities", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelFloors", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelImages", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelMapLocation", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.CityMapLocation", "CityMapLocation")
                        .WithMany()
                        .HasForeignKey("CityMapLocationId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelReview", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.Hotel", "hotel")
                        .WithMany()
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.HotelRoom", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.HotelFloors", "HotelFloors")
                        .WithMany()
                        .HasForeignKey("HotelFloorsId");

                    b.HasOne("HotelCloudBedSystem.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId");

                    b.HasOne("HotelCloudBedSystem.Models.HotelRoomType", "HotelRoomType")
                        .WithMany()
                        .HasForeignKey("HotelRoomTypeId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.Payment", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.HotelRoom", "HotelRoom")
                        .WithMany()
                        .HasForeignKey("HotelRoomId");

                    b.HasOne("HotelCloudBedSystem.Models.RoomReservation", "RoomReservation")
                        .WithMany()
                        .HasForeignKey("RoomReservationId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomFacilities", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.HotelRoom", "HotelRoom")
                        .WithMany()
                        .HasForeignKey("HotelRoomId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomReservation", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("HotelCloudBedSystem.Models.HotelRoom", "Hotelroom")
                        .WithMany()
                        .HasForeignKey("HotelRoomId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomReview", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.HotelRoom", "hotelRoom")
                        .WithMany()
                        .HasForeignKey("HotelRoomId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.RoomsImage", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.HotelRoom", "HotelRoom")
                        .WithMany()
                        .HasForeignKey("HotelRoomId");
                });

            modelBuilder.Entity("HotelCloudBedSystem.Models.TemporaryRoomType", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.Hotel", "hotel")
                        .WithMany()
                        .HasForeignKey("HotelId");

                    b.HasOne("HotelCloudBedSystem.Models.HotelRoomType", "HotelRoomType")
                        .WithMany()
                        .HasForeignKey("HotelRoomTypeId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HotelCloudBedSystem.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HotelCloudBedSystem.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
