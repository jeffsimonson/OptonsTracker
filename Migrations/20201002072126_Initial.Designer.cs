﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OptionsTracker.Data;

namespace OptionsTracker.Migrations
{
    [DbContext(typeof(OptionsTrackerContext))]
    [Migration("20201002072126_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OptionsTracker.Models.Market", b =>
                {
                    b.Property<string>("MarketID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PointValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("QuoteStyle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarketID");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("OptionsTracker.Models.Trade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CommissionFees")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ContractMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("EntryPrice")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("ExitPrice")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Market")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrOfContracts")
                        .HasColumnType("int");

                    b.Property<string>("StrikePrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trade");
                });
#pragma warning restore 612, 618
        }
    }
}
