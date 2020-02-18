﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rapnetApi.Models;

namespace rapnetApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200218161137_DiamondsMigration")]
    partial class DiamondsMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("rapnetApi.Models.Diamond", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clarity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ListPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Size")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Diamonds");

                    b.HasData(
                        new
                        {
                            Id = 1m,
                            Clarity = "IF",
                            Color = "D",
                            ListPrice = 18000m,
                            Price = 15000m,
                            Size = 1.02m
                        },
                        new
                        {
                            Id = 2m,
                            Clarity = "VVS1",
                            Color = "E",
                            ListPrice = 21000m,
                            Price = 20000m,
                            Size = 1.5m
                        },
                        new
                        {
                            Id = 3m,
                            Clarity = "VVS2",
                            Color = "G",
                            ListPrice = 10000m,
                            Price = 12000m,
                            Size = 0.95m
                        },
                        new
                        {
                            Id = 4m,
                            Clarity = "I2",
                            Color = "F",
                            ListPrice = 55000m,
                            Price = 50000m,
                            Size = 2.15m
                        },
                        new
                        {
                            Id = 5m,
                            Clarity = "IF",
                            Color = "D",
                            ListPrice = 3000m,
                            Price = 2000m,
                            Size = 0.5m
                        },
                        new
                        {
                            Id = 6m,
                            Clarity = "I1",
                            Color = "G",
                            ListPrice = 12000m,
                            Price = 15000m,
                            Size = 1.2m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
