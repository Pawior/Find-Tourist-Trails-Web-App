﻿// <auto-generated />
using System;
using Find_Tourist_Trails.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Find_Tourist_Trails.Migrations
{
    [DbContext(typeof(TrailsDbContext))]
    [Migration("20231017175623_sqldbMain")]
    partial class sqldbMain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Polish_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Find_Tourist_Trails.Models.Trails", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nchar(150)")
                        .IsFixedLength();

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("MapLink")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<string>("Region")
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .IsFixedLength();

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trails");
                });
#pragma warning restore 612, 618
        }
    }
}
