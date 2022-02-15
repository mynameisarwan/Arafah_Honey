﻿// <auto-generated />
using System;
using Arafah_Honey.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Arafah_Honey.Migrations
{
    [DbContext(typeof(ArafahDataContext))]
    partial class ArafahDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Arafah_Honey.Models.Neracas", b =>
                {
                    b.Property<string>("neraca_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("QTY")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<string>("debitkredit")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("keterangan")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<decimal>("nominal")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<DateTime>("tanggal_neraca")
                        .HasColumnType("datetime2");

                    b.HasKey("neraca_id");

                    b.ToTable("tbl_mst_neraca");
                });

            modelBuilder.Entity("Arafah_Honey.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("tbl_mst_user");
                });
#pragma warning restore 612, 618
        }
    }
}
