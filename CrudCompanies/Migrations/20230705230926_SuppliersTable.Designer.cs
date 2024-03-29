﻿// <auto-generated />
using CrudCompanies.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudCompanies.Migrations
{
    [DbContext(typeof(CompaniesContext))]
    [Migration("20230705230926_SuppliersTable")]
    partial class SuppliersTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudCompanies.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("business_name");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("cep");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cnpj");

                    b.HasKey("Id");

                    b.ToTable("tb_company", (string)null);
                });

            modelBuilder.Entity("CrudCompanies.Model.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cpf_cnpj");

                    b.HasKey("Id");

                    b.ToTable("tb_supplier", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
