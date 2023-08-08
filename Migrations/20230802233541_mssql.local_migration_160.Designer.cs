﻿// <auto-generated />
using System;
using HastaneRandevuSistemi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HastaneRandevuSistemi.Migrations
{
    [DbContext(typeof(HastaneContext))]
    [Migration("20230802233541_mssql.local_migration_160")]
    partial class mssqllocal_migration_160
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Birim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("PoliklinikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PoliklinikId");

                    b.ToTable("Birims");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Doktor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BirimId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Poliklinik")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("PoliklinikId")
                        .HasColumnType("int");

                    b.Property<int?>("RandevuId")
                        .HasColumnType("int");

                    b.Property<string>("SoyIsim")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.HasIndex("RandevuId");

                    b.ToTable("Doktors");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Hasta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HastalikId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SoyIsim")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TelefonNumarasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HastalikId");

                    b.ToTable("Hastas");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Hastalik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Belirti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hastaliks");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Poliklinik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Polikliniks");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoktorId")
                        .HasColumnType("int");

                    b.Property<int>("HastaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoktorId");

                    b.HasIndex("HastaId");

                    b.ToTable("Randevus");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Birim", b =>
                {
                    b.HasOne("HastaneRandevuSistemi.Models.Poliklinik", null)
                        .WithMany("Birims")
                        .HasForeignKey("PoliklinikId");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Doktor", b =>
                {
                    b.HasOne("HastaneRandevuSistemi.Models.Birim", "Birim")
                        .WithMany("Doktors")
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HastaneRandevuSistemi.Models.Randevu", null)
                        .WithMany("Doktors")
                        .HasForeignKey("RandevuId");

                    b.Navigation("Birim");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Hasta", b =>
                {
                    b.HasOne("HastaneRandevuSistemi.Models.Hastalik", null)
                        .WithMany("Hastas")
                        .HasForeignKey("HastalikId");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Randevu", b =>
                {
                    b.HasOne("HastaneRandevuSistemi.Models.Doktor", "Doktor")
                        .WithMany()
                        .HasForeignKey("DoktorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HastaneRandevuSistemi.Models.Hasta", "Hasta")
                        .WithMany("Randevular")
                        .HasForeignKey("HastaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doktor");

                    b.Navigation("Hasta");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Birim", b =>
                {
                    b.Navigation("Doktors");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Hasta", b =>
                {
                    b.Navigation("Randevular");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Hastalik", b =>
                {
                    b.Navigation("Hastas");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Poliklinik", b =>
                {
                    b.Navigation("Birims");
                });

            modelBuilder.Entity("HastaneRandevuSistemi.Models.Randevu", b =>
                {
                    b.Navigation("Doktors");
                });
#pragma warning restore 612, 618
        }
    }
}
