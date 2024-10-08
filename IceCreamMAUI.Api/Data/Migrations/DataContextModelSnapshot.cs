﻿// <auto-generated />
using System;
using IceCreamMAUI.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IceCreamMAUI.Api.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.Icecream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Icecreams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",
                            Name = "Vanilla Delight",
                            Price = 6.25
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",
                            Name = "chocoBerry Bliss",
                            Price = 6.25
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",
                            Name = "Vanilla Delight",
                            Price = 6.25
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",
                            Name = "Vanilla Delight",
                            Price = 6.25
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",
                            Name = "Vanilla Delight",
                            Price = 6.25
                        });
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.IcecreamOption", b =>
                {
                    b.Property<int>("IcecreamId")
                        .HasColumnType("int");

                    b.Property<string>("Flavor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Topping")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IcecreamId", "Flavor", "Topping");

                    b.ToTable("IcecreamOptions");

                    b.HasData(
                        new
                        {
                            IcecreamId = 1,
                            Flavor = "Vanilla",
                            Topping = "default"
                        },
                        new
                        {
                            IcecreamId = 2,
                            Flavor = "Vanilla",
                            Topping = "default"
                        },
                        new
                        {
                            IcecreamId = 3,
                            Flavor = "Vanilla",
                            Topping = "default"
                        },
                        new
                        {
                            IcecreamId = 4,
                            Flavor = "Vanilla",
                            Topping = "default"
                        });
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("OrderedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Flavor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IcecreamId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Topping")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.IcecreamOption", b =>
                {
                    b.HasOne("IceCreamMAUI.Api.Data.Entities.Icecream", "icecream")
                        .WithMany("Options")
                        .HasForeignKey("IcecreamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("icecream");
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.OrderItem", b =>
                {
                    b.HasOne("IceCreamMAUI.Api.Data.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.Icecream", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("IceCreamMAUI.Api.Data.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
