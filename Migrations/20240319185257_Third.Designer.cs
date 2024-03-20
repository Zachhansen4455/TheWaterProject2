﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheWaterProject2.Models;

#nullable disable

namespace TheWaterProject2.Migrations
{
    [DbContext(typeof(WaterProjectContext))]
    [Migration("20240319185257_Third")]
    partial class Third
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("TheWaterProject2.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectImpact")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ProjectInstallation")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectPhase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectType")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
