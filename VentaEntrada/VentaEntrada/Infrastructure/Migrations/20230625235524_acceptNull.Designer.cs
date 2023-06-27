﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VentaEntrada.Infrastructure.Persistence;

#nullable disable

namespace VentaEntrada.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230625235524_acceptNull")]
    partial class acceptNull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PuertaDeEntrada.Domain.Entities.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<bool>("isFree")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("PuertaDeEntrada.Domain.Entities.Transaction", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idTransaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("posicion")
                        .HasColumnType("int");

                    b.Property<double?>("timeSpan")
                        .HasColumnType("float");

                    b.HasKey("email");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
