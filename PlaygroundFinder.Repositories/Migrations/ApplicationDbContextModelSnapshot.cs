﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PlaygroundFinder.Repositories;

namespace PlaygroundFinder.Repositories.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresExtension("postgis")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.AgeRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AgeRanges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            type = "Junior"
                        },
                        new
                        {
                            Id = 2,
                            type = "Senior"
                        });
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.GroundCover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Material")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GroundCovers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Material = "Natural Round Rock"
                        },
                        new
                        {
                            Id = 2,
                            Material = "Sand"
                        },
                        new
                        {
                            Id = 3,
                            Material = "Wood Chips"
                        },
                        new
                        {
                            Id = 4,
                            Material = "Poured In Place Rubber"
                        },
                        new
                        {
                            Id = 5,
                            Material = "Crumb Rubber"
                        },
                        new
                        {
                            Id = 6,
                            Material = "Other"
                        });
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.Playground", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Accessible")
                        .HasColumnType("boolean");

                    b.Property<Point>("GeoLocation")
                        .IsRequired()
                        .HasColumnType("geography (point)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Quadrant")
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Playgrounds");
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.PlaygroundAgeRange", b =>
                {
                    b.Property<Guid>("PlaygroundId")
                        .HasColumnType("uuid");

                    b.Property<int>("AgeRangeId")
                        .HasColumnType("integer");

                    b.HasKey("PlaygroundId", "AgeRangeId");

                    b.HasIndex("AgeRangeId");

                    b.ToTable("PlaygroundAgeRanges");
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.PlaygroundGroundCover", b =>
                {
                    b.Property<Guid>("PlaygroundId")
                        .HasColumnType("uuid");

                    b.Property<int>("GroundCoverId")
                        .HasColumnType("integer");

                    b.HasKey("PlaygroundId", "GroundCoverId");

                    b.HasIndex("GroundCoverId");

                    b.ToTable("PlaygroundGroundCovers");
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.PlaygroundAgeRange", b =>
                {
                    b.HasOne("PlaygroundFinder.Models.Entities.AgeRange", null)
                        .WithMany("Playgrounds")
                        .HasForeignKey("AgeRangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlaygroundFinder.Models.Entities.Playground", null)
                        .WithMany("AgeRanges")
                        .HasForeignKey("PlaygroundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.PlaygroundGroundCover", b =>
                {
                    b.HasOne("PlaygroundFinder.Models.Entities.GroundCover", null)
                        .WithMany("Playgrounds")
                        .HasForeignKey("GroundCoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlaygroundFinder.Models.Entities.Playground", null)
                        .WithMany("GroundCovers")
                        .HasForeignKey("PlaygroundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.AgeRange", b =>
                {
                    b.Navigation("Playgrounds");
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.GroundCover", b =>
                {
                    b.Navigation("Playgrounds");
                });

            modelBuilder.Entity("PlaygroundFinder.Models.Entities.Playground", b =>
                {
                    b.Navigation("AgeRanges");

                    b.Navigation("GroundCovers");
                });
#pragma warning restore 612, 618
        }
    }
}
