﻿// <auto-generated />
using Integration_Class_Library.PharmacyEntity.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Integration_Class_Library.Migrations
{
    [DbContext(typeof(PharmacyDbContext))]
    partial class PharmacyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Integration_Class_Library.Models.Pharmacy", b =>
                {
                    b.Property<string>("IdPharmacy")
                        .HasColumnType("text");

                    b.Property<string>("ApiKeyPharmacy")
                        .HasColumnType("text");

                    b.Property<string>("Endpoint")
                        .HasColumnType("text");

                    b.Property<string>("NamePharmacy")
                        .HasColumnType("text");

                    b.HasKey("IdPharmacy");

                    b.ToTable("Pharmacies");

                    b.HasData(
                        new
                        {
                            IdPharmacy = "P1",
                            ApiKeyPharmacy = "ABCD1234",
                            Endpoint = "www.pharmacy1.rs",
                            NamePharmacy = "Pharmacy 1"
                        },
                        new
                        {
                            IdPharmacy = "P2",
                            ApiKeyPharmacy = "EFGH1234",
                            Endpoint = "www.pharmacy2.rs",
                            NamePharmacy = "Pharmacy 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
