﻿// <auto-generated />
using System;
using MakerTracker.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MakerTracker.Migrations
{
    [DbContext(typeof(MakerTrackerContext))]
    [Migration("20200329220640_MoreTables")]
    partial class MoreTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MakerTracker.DBModels.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerProfileId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MakerTracker.DBModels.CustomerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FulFillByDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerOrder");
                });

            modelBuilder.Entity("MakerTracker.DBModels.CustomerOrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerOrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerOrderDetail");
                });

            modelBuilder.Entity("MakerTracker.DBModels.CustomerStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerStock");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Maker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AccessToFaceMask")
                        .HasColumnType("bit");

                    b.Property<bool>("AccessToGloves")
                        .HasColumnType("bit");

                    b.Property<bool>("HasCadSkills")
                        .HasColumnType("bit");

                    b.Property<int?>("OwnerProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerProfileId");

                    b.ToTable("Makers");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int?>("MakerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("MakerId");

                    b.ToTable("MakerEquipment");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MakerId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.HasIndex("MaterialId");

                    b.ToTable("MakerMaterial");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpectedFinished")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MakerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PromisedCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.HasIndex("ProductId");

                    b.ToTable("MakerOrder");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MakerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.HasIndex("ProductId");

                    b.ToTable("MakerStock");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructionUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Auth0Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSelfQuarantined")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Customer", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Profile", "OwnerProfile")
                        .WithMany()
                        .HasForeignKey("OwnerProfileId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.CustomerOrder", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.CustomerOrderDetail", b =>
                {
                    b.HasOne("MakerTracker.DBModels.CustomerOrder", "CustomerOrder")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CustomerOrderId");

                    b.HasOne("MakerTracker.DBModels.Product", "Product")
                        .WithMany("OnOrders")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.CustomerStock", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Customer", "Customer")
                        .WithMany("Stocks")
                        .HasForeignKey("CustomerId");

                    b.HasOne("MakerTracker.DBModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Maker", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Profile", "OwnerProfile")
                        .WithMany()
                        .HasForeignKey("OwnerProfileId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerEquipment", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Equipment", "Equipment")
                        .WithMany("UsedBy")
                        .HasForeignKey("EquipmentId");

                    b.HasOne("MakerTracker.DBModels.Maker", "Maker")
                        .WithMany("Equipment")
                        .HasForeignKey("MakerId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerMaterial", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Maker", "Maker")
                        .WithMany("Materials")
                        .HasForeignKey("MakerId");

                    b.HasOne("MakerTracker.DBModels.Material", "Material")
                        .WithMany("UsedBy")
                        .HasForeignKey("MaterialId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerOrder", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Maker", "Maker")
                        .WithMany("MakerQueue")
                        .HasForeignKey("MakerId");

                    b.HasOne("MakerTracker.DBModels.Product", "Product")
                        .WithMany("InMakerQueues")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerStock", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Maker", "Maker")
                        .WithMany("Stocks")
                        .HasForeignKey("MakerId");

                    b.HasOne("MakerTracker.DBModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
