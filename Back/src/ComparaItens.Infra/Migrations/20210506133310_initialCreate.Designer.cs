﻿// <auto-generated />
using ComparaItens.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComparaItens.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210506133310_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComparaItens.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("tabCategory");
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.Characteristic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("tabCharacteristic");
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.CharacteristicDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<int>("CharacteristicId")
                        .HasColumnName("characteristicId")
                        .HasColumnType("int(11)");

                    b.Property<int>("CharacteristicKeyId")
                        .HasColumnName("characteristicKeyId")
                        .HasColumnType("int(11)");

                    b.Property<int>("ProductId")
                        .HasColumnName("productId")
                        .HasColumnType("int(11)");

                    b.HasKey("Id");

                    b.HasIndex("CharacteristicId");

                    b.HasIndex("CharacteristicKeyId");

                    b.HasIndex("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("tabCharacteristicDescription");
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.CharacteristicKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnName("key")
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("tabCharacteristicKey");
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("tabManufacturer");
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<int>("CategoryId")
                        .HasColumnName("categoryId")
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Folder")
                        .HasColumnName("folder")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Image")
                        .HasColumnName("image")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnName("manufecturerId")
                        .HasColumnType("int(11)");

                    b.Property<string>("Model")
                        .HasColumnName("model")
                        .HasColumnType("varchar(150)");

                    b.Property<int>("YearOfManufacture")
                        .HasColumnName("yearOfManufacture")
                        .HasColumnType("int(11)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("tabProdut");
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("login")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnName("role")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("tabUser");
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.CharacteristicDescription", b =>
                {
                    b.HasOne("ComparaItens.Domain.Entities.Characteristic", "Characteristics")
                        .WithMany()
                        .HasForeignKey("CharacteristicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComparaItens.Domain.Entities.CharacteristicKey", "CharacteristicKeys")
                        .WithMany()
                        .HasForeignKey("CharacteristicKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComparaItens.Domain.Entities.Product", b =>
                {
                    b.HasOne("ComparaItens.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComparaItens.Domain.Entities.Manufacturer", "Manufecturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
