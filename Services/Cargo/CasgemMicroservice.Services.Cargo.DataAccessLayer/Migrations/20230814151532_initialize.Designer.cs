﻿// <auto-generated />
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Migrations
{
    [DbContext(typeof(CargoContext))]
    [Migration("20230814151532_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities.CargoDetail", b =>
                {
                    b.Property<int>("CargoDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoDetailId"), 1L, 1);

                    b.Property<int>("CargoStateId")
                        .HasColumnType("int");

                    b.Property<int>("OrderingId")
                        .HasColumnType("int");

                    b.HasKey("CargoDetailId");

                    b.HasIndex("CargoStateId");

                    b.ToTable("CargoDetails");
                });

            modelBuilder.Entity("CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities.CargoState", b =>
                {
                    b.Property<int>("CargoStateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoStateId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoStateId");

                    b.ToTable("CargoStates");
                });

            modelBuilder.Entity("CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities.CargoDetail", b =>
                {
                    b.HasOne("CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities.CargoState", "CargoState")
                        .WithMany("CargoDetails")
                        .HasForeignKey("CargoStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoState");
                });

            modelBuilder.Entity("CasgemMicroservice.Serivces.Cargo.EntityLayer.Entities.CargoState", b =>
                {
                    b.Navigation("CargoDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
