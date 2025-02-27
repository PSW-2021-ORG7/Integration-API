﻿// <auto-generated />
using Integration_Class_Library.PharmacyEntity.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Integration_Class_Library.Migrations
{
    [DbContext(typeof(IntegrationDbContext))]
    [Migration("20211212165506_PrescriptionMigration")]
    partial class PrescriptionMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Integration_Class_Library.Models.Pharmacy", b =>
                {
                    b.Property<int>("IdPharmacy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("ApiKeyPharmacy")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Contact")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Endpoint")
                        .HasColumnType("text");

                    b.Property<string>("NamePharmacy")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.HasKey("IdPharmacy");

                    b.ToTable("Pharmacy");
                });

            modelBuilder.Entity("Integration_Class_Library.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("IdPrescription");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Integration_Class_Library.PharmacyEntity.Models.Feedback", b =>
                {
                    b.Property<int>("IdFeedback")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ContentFeedback")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdPharmacy")
                        .HasColumnType("integer");

                    b.HasKey("IdFeedback");

                    b.ToTable("Response");
                });
#pragma warning restore 612, 618
        }
    }
}
