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
    [Migration("20230706234753_ManyToManyRel")]
    partial class ManyToManyRel
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
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("cep");

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

            modelBuilder.Entity("CrudCompanies.Model.SupplierCompany", b =>
                {
                    b.Property<int>("CompanyID")
                        .HasColumnType("int")
                        .HasColumnName("id_company");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("id_supplier");

                    b.HasKey("CompanyID", "SupplierId");

                    b.HasIndex("SupplierId");

                    b.ToTable("tb_supplier_company", (string)null);
                });

            modelBuilder.Entity("CrudCompanies.Model.SupplierCompany", b =>
                {
                    b.HasOne("CrudCompanies.Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrudCompanies.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}