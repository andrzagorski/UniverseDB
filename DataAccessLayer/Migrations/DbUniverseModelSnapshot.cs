﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace DAL_DataAccessLayer.Migrations
{
    [DbContext(typeof(DbUniverse))]
    partial class DbUniverseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiscovererStarSystem", b =>
                {
                    b.Property<int>("DiscoverersId")
                        .HasColumnType("int");

                    b.Property<int>("StarSystemsId")
                        .HasColumnType("int");

                    b.HasKey("DiscoverersId", "StarSystemsId");

                    b.HasIndex("StarSystemsId");

                    b.ToTable("DiscovererStarSystem");
                });

            modelBuilder.Entity("Universe.Models.discoverer.Discoverer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ShipId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShipId")
                        .IsUnique()
                        .HasFilter("[ShipId] IS NOT NULL");

                    b.ToTable("Discoverers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 43,
                            Name = "Piotrek",
                            ShipId = 1,
                            Surname = "Piotrowski"
                        },
                        new
                        {
                            Id = 2,
                            Age = 34,
                            Name = "Marek",
                            Surname = "Markowski"
                        },
                        new
                        {
                            Id = 3,
                            Age = 30,
                            Name = "Darek",
                            Surname = "Darkowski"
                        });
                });

            modelBuilder.Entity("Universe.Models.galaxy.Galaxy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Galaxies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mass = 10000000000000.0,
                            Name = "Droga Mleczna",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Mass = 10000000000000.0,
                            Name = "Messier 87",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Mass = 10000000000000000.0,
                            Name = "GAL-CLUS-022058s",
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Mass = 10000000000.0,
                            Name = "Wielka Mgławica Magellana",
                            Type = 3
                        });
                });

            modelBuilder.Entity("Universe.Models.planet.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GalaxyId")
                        .HasColumnType("int");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("StarSystemId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GalaxyId");

                    b.HasIndex("StarSystemId");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mass = 2000000000000.0,
                            Name = "Jupiter",
                            StarSystemId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Mass = 2000000000000.0,
                            Name = "Neptune",
                            StarSystemId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            Mass = 2000000000000.0,
                            Name = "Uranus",
                            StarSystemId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 4,
                            Mass = 2000000000000.0,
                            Name = "Saturn",
                            StarSystemId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 5,
                            Mass = 3000000000000.0,
                            Name = "Pluto",
                            StarSystemId = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 6,
                            Mass = 4000000000000.0,
                            Name = "Kepler-438b",
                            StarSystemId = 2,
                            Type = 2
                        },
                        new
                        {
                            Id = 7,
                            Mass = 5000000000000.0,
                            Name = "Earth",
                            StarSystemId = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 8,
                            Mass = 5000000000000.0,
                            Name = "Mars",
                            StarSystemId = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 9,
                            Mass = 6000000000000.0,
                            Name = "Charon",
                            StarSystemId = 3,
                            Type = 4
                        });
                });

            modelBuilder.Entity("Universe.Models.ship.Ship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IfBroken")
                        .HasColumnType("bit");

                    b.Property<int>("MaxSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SingleChargeRange")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ships");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IfBroken = false,
                            MaxSpeed = 10,
                            Name = "StarShip_1",
                            ShipModel = "m0001",
                            SingleChargeRange = 12
                        },
                        new
                        {
                            Id = 2,
                            IfBroken = false,
                            MaxSpeed = 100,
                            Name = " StarShip_2",
                            ShipModel = "m0002",
                            SingleChargeRange = 120
                        },
                        new
                        {
                            Id = 3,
                            IfBroken = true,
                            MaxSpeed = 1000,
                            Name = "StarShip_3",
                            ShipModel = "m0003",
                            SingleChargeRange = 122
                        });
                });

            modelBuilder.Entity("Universe.Models.star.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("Luminosity")
                        .HasColumnType("float");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Radius")
                        .HasColumnType("float");

                    b.Property<int>("StarSystemId")
                        .HasColumnType("int");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StarSystemId");

                    b.ToTable("Stars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 10000,
                            Luminosity = 23.0,
                            Mass = 1000000.0,
                            Name = "Zeta",
                            Radius = 22.100000000000001,
                            StarSystemId = 1,
                            Temperature = 30.0,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 1000,
                            Luminosity = 233.0,
                            Mass = 100000.0,
                            Name = "Aldebaran",
                            Radius = 232.09999999999999,
                            StarSystemId = 1,
                            Temperature = 303.0,
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 10000,
                            Luminosity = 3.0,
                            Mass = 1000000.0,
                            Name = "SiriusB",
                            Radius = 322.10000000000002,
                            StarSystemId = 1,
                            Temperature = 130.0,
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Age = 100000,
                            Luminosity = 235.0,
                            Mass = 100000000.0,
                            Name = "PSR_B1509-58",
                            Radius = 2.1000000000000001,
                            StarSystemId = 3,
                            Temperature = 0.0,
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            Age = 100000,
                            Luminosity = 0.0,
                            Mass = 100000000.0,
                            Name = "Cygnus X-1",
                            Radius = 33334.099999999999,
                            StarSystemId = 2,
                            Temperature = -22.0,
                            Type = 4
                        });
                });

            modelBuilder.Entity("Universe.Models.starsystem.StarSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GalaxyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GalaxyId");

                    b.ToTable("StarSystems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GalaxyId = 1,
                            Name = "Wolarz"
                        },
                        new
                        {
                            Id = 2,
                            GalaxyId = 2,
                            Name = "Orzel"
                        },
                        new
                        {
                            Id = 3,
                            GalaxyId = 3,
                            Name = "Skorpion"
                        },
                        new
                        {
                            Id = 4,
                            GalaxyId = 4,
                            Name = "Strzelec"
                        });
                });

            modelBuilder.Entity("DiscovererStarSystem", b =>
                {
                    b.HasOne("Universe.Models.discoverer.Discoverer", null)
                        .WithMany()
                        .HasForeignKey("DiscoverersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Universe.Models.starsystem.StarSystem", null)
                        .WithMany()
                        .HasForeignKey("StarSystemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Universe.Models.discoverer.Discoverer", b =>
                {
                    b.HasOne("Universe.Models.ship.Ship", "Ship")
                        .WithOne("Discoverer")
                        .HasForeignKey("Universe.Models.discoverer.Discoverer", "ShipId");

                    b.Navigation("Ship");
                });

            modelBuilder.Entity("Universe.Models.planet.Planet", b =>
                {
                    b.HasOne("Universe.Models.galaxy.Galaxy", null)
                        .WithMany("StarSystems")
                        .HasForeignKey("GalaxyId");

                    b.HasOne("Universe.Models.starsystem.StarSystem", "StarSystem")
                        .WithMany("Planets")
                        .HasForeignKey("StarSystemId");

                    b.Navigation("StarSystem");
                });

            modelBuilder.Entity("Universe.Models.star.Star", b =>
                {
                    b.HasOne("Universe.Models.starsystem.StarSystem", "StarSystem")
                        .WithMany("Stars")
                        .HasForeignKey("StarSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StarSystem");
                });

            modelBuilder.Entity("Universe.Models.starsystem.StarSystem", b =>
                {
                    b.HasOne("Universe.Models.galaxy.Galaxy", "Galaxy")
                        .WithMany()
                        .HasForeignKey("GalaxyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Galaxy");
                });

            modelBuilder.Entity("Universe.Models.galaxy.Galaxy", b =>
                {
                    b.Navigation("StarSystems");
                });

            modelBuilder.Entity("Universe.Models.ship.Ship", b =>
                {
                    b.Navigation("Discoverer");
                });

            modelBuilder.Entity("Universe.Models.starsystem.StarSystem", b =>
                {
                    b.Navigation("Planets");

                    b.Navigation("Stars");
                });
#pragma warning restore 612, 618
        }
    }
}
