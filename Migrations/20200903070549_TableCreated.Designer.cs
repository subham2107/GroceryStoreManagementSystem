﻿// <auto-generated />
using System;
using GroceryStoreMgmt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryStoreMgmt.Migrations
{
    [DbContext(typeof(GrocContext))]
    [Migration("20200903070549_TableCreated")]
    partial class TableCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryStoreMgmt.Models.grocitem", b =>
                {
                    b.Property<int>("GrocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GrocName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GrocPrice")
                        .HasColumnType("float");

                    b.Property<int>("GrocQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("GrocTime")
                        .HasColumnType("datetime2");

                    b.HasKey("GrocId");

                    b.ToTable("grocitems");
                });

            modelBuilder.Entity("GroceryStoreMgmt.Models.grocsell", b =>
                {
                    b.Property<int>("SellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrocBuyTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GrocId")
                        .HasColumnType("int");

                    b.Property<int>("GrocQuantity")
                        .HasColumnType("int");

                    b.HasKey("SellId");

                    b.ToTable("grocsells");
                });
#pragma warning restore 612, 618
        }
    }
}
