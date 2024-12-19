﻿// <auto-generated />
using System;
using DataBaseStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataBaseStorage.Migrations
{
    [DbContext(typeof(context))]
    partial class contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataBaseStorage.entities.detail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Alpha1")
                        .HasColumnType("float");

                    b.Property<double>("Beta")
                        .HasColumnType("float");

                    b.Property<double>("D1")
                        .HasColumnType("float");

                    b.Property<double>("Dmin_Sigma")
                        .HasColumnType("float");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material_P")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("N")
                        .HasColumnType("float");

                    b.Property<double>("N_V")
                        .HasColumnType("float");

                    b.Property<double>("Sigma")
                        .HasColumnType("float");

                    b.Property<double>("U")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("details");
                });

            modelBuilder.Entity("DataBaseStorage.entities.resultEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Crossectionalarea")
                        .HasColumnType("float");

                    b.Property<double>("F")
                        .HasColumnType("float");

                    b.Property<double>("Sigma")
                        .HasColumnType("float");

                    b.Property<double>("Sigma0")
                        .HasColumnType("float");

                    b.Property<double>("SigmaF")
                        .HasColumnType("float");

                    b.Property<Guid>("detailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("unitId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("detailId");

                    b.HasIndex("unitId");

                    b.ToTable("resultEntities");
                });

            modelBuilder.Entity("DataBaseStorage.entities.unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("A")
                        .HasColumnType("float");

                    b.Property<double>("C0")
                        .HasColumnType("float");

                    b.Property<double>("C1")
                        .HasColumnType("float");

                    b.Property<double>("C2")
                        .HasColumnType("float");

                    b.Property<double>("C3")
                        .HasColumnType("float");

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Crossectionalarea")
                        .HasColumnType("float");

                    b.Property<double>("F")
                        .HasColumnType("float");

                    b.Property<string>("MezOs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Natyazh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sigma0")
                        .HasColumnType("float");

                    b.Property<double>("SigmaF")
                        .HasColumnType("float");

                    b.Property<double>("SigmaF0")
                        .HasColumnType("float");

                    b.Property<string>("TypeofEngine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeofMachine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("W")
                        .HasColumnType("float");

                    b.Property<double>("b")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("units");
                });

            modelBuilder.Entity("DataBaseStorage.entities.resultEntity", b =>
                {
                    b.HasOne("DataBaseStorage.entities.detail", "detail")
                        .WithMany()
                        .HasForeignKey("detailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBaseStorage.entities.unit", "unit")
                        .WithMany()
                        .HasForeignKey("unitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("detail");

                    b.Navigation("unit");
                });
#pragma warning restore 612, 618
        }
    }
}
