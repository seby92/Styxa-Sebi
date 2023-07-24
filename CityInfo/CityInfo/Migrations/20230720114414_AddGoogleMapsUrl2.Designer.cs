﻿// <auto-generated />
using CityInfo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CityInfo.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    [Migration("20230720114414_AddGoogleMapsUrl2")]
    partial class AddGoogleMapsUrl2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CityInfo.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("GoogleMapsUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The one with that big park.",
                            GoogleMapsUrl = "https://goo.gl/maps/6CzStBQzmS46u6Z69",
                            Name = "New York City",
                            Population = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "The one with the cathedral that was never really finished.",
                            GoogleMapsUrl = "https://goo.gl/maps/eGrxrSKEyMb1H9Lm7",
                            Name = "Antwerp",
                            Population = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "The one with that big tower.",
                            GoogleMapsUrl = "https://goo.gl/maps/SLHYQd8Vu1U2Xv8M6",
                            Name = "Paris",
                            Population = 0
                        });
                });

            modelBuilder.Entity("CityInfo.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("GoogleMapsUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "The most visited urban park in the United States.",
                            GoogleMapsUrl = "https://goo.gl/maps/iWzWAr2jXvehXVTJ6",
                            Name = "Central Park"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "A 102-story skyscraper located in Midtown Manhattan.",
                            GoogleMapsUrl = "https://goo.gl/maps/9zkBjJfY3wgjcX488",
                            Name = "Empire State Building"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans.",
                            GoogleMapsUrl = "https://goo.gl/maps/8fdVULE4Diss8uHq6",
                            Name = "Cathedral"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "The the finest example of railway architecture in Belgium.",
                            GoogleMapsUrl = "https://goo.gl/maps/5a558knHtLdXeRSW6",
                            Name = "Antwerp Central Station"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel.",
                            GoogleMapsUrl = "https://goo.gl/maps/UCY5ATXU2hig95ZR9",
                            Name = "Eiffel Tower"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Description = "The world's largest museum.",
                            GoogleMapsUrl = "https://goo.gl/maps/6SUECXNRKev1K9aL8",
                            Name = "The Louvre"
                        });
                });

            modelBuilder.Entity("CityInfo.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAdmin = true,
                            Password = "admin",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            IsAdmin = false,
                            Password = "user",
                            Username = "user"
                        });
                });

            modelBuilder.Entity("CityInfo.Entities.PointOfInterest", b =>
                {
                    b.HasOne("CityInfo.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}