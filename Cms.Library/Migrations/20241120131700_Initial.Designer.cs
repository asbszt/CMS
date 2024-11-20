﻿// <auto-generated />
using System;
using Cms.Library.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cms.Library.Migrations
{
    [DbContext(typeof(CmsDbContext))]
    [Migration("20241120131700_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Cms.Library.Models.CustomerInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CarNo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CardNo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CardType")
                        .HasColumnType("int");

                    b.Property<string>("CustomerId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(59)
                        .HasColumnType("varchar(59)");

                    b.HasKey("Id");

                    b.ToTable("CustomerInfos");
                });

            modelBuilder.Entity("Cms.Library.Models.CustomerRetailFlow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("ActualAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ItemBarcode")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("ItemId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ItemName")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ItemQuantity")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ItemTotalAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("RetailId")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid?>("RetailMasterId")
                        .HasColumnType("char(36)");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RetailMasterId");

                    b.ToTable("CustomerRetailFlows");
                });

            modelBuilder.Entity("Cms.Library.Models.CustomerRetailMaster", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CustomerId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("InvoiceNumber")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("InvoiceStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("RetailAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("RetailDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RetailId")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("RetailMemo")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("CustomerRetailMasters");
                });

            modelBuilder.Entity("Cms.Library.Models.SystemSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Memo")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SystemSettings");
                });

            modelBuilder.Entity("Cms.Library.Models.CustomerRetailFlow", b =>
                {
                    b.HasOne("Cms.Library.Models.CustomerRetailMaster", "RetailMaster")
                        .WithMany("CustomerRetailFlows")
                        .HasForeignKey("RetailMasterId");

                    b.Navigation("RetailMaster");
                });

            modelBuilder.Entity("Cms.Library.Models.CustomerRetailMaster", b =>
                {
                    b.Navigation("CustomerRetailFlows");
                });
#pragma warning restore 612, 618
        }
    }
}
