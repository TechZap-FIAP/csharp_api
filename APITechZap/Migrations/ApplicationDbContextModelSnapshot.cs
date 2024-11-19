﻿// <auto-generated />
using System;
using APITechZap.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace APITechZap.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APITechZap.Models.Address", b =>
                {
                    b.Property<int>("IdAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_ADDRESS");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAddress"));

                    b.Property<string>("DsCity")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_CITY");

                    b.Property<string>("DsComplement")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_COMPLEMENT");

                    b.Property<string>("DsNeighborhood")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_NEIGHBORHOOD");

                    b.Property<int?>("DsNumber")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("DS_NUMBER");

                    b.Property<string>("DsState")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_STATE");

                    b.Property<string>("DsStreet")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_STREET");

                    b.Property<string>("DsZipCode")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_ZIPCODE");

                    b.Property<DateTime>("DtCreatedAt")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_CREATED_AT");

                    b.Property<DateTime?>("DtUpdatedAt")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_UPDATED_AT");

                    b.Property<int>("IdUser")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USER");

                    b.HasKey("IdAddress");

                    b.HasIndex("IdUser")
                        .IsUnique();

                    b.ToTable("T_TZ_ADDRESS");
                });

            modelBuilder.Entity("APITechZap.Models.ContractedPlan", b =>
                {
                    b.Property<int>("IdContractedPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_CONTRACTED_PLAN");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContractedPlan"));

                    b.Property<DateTime>("DtCreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("DtDeletedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("DtUpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("IdSolarPanel")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_SOLAR_PANEL");

                    b.Property<int?>("IdUser")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USER");

                    b.Property<int?>("IdWindTurbine")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_WIND_TURBINE");

                    b.HasKey("IdContractedPlan");

                    b.HasIndex("IdSolarPanel")
                        .IsUnique()
                        .HasFilter("\"ID_SOLAR_PANEL\" IS NOT NULL");

                    b.HasIndex("IdUser");

                    b.HasIndex("IdWindTurbine")
                        .IsUnique()
                        .HasFilter("\"ID_WIND_TURBINE\" IS NOT NULL");

                    b.ToTable("T_TZ_CONTRACTED_PLAN");
                });

            modelBuilder.Entity("APITechZap.Models.SolarPanel", b =>
                {
                    b.Property<int>("IdSolarPanel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_SOLAR_PANEL");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSolarPanel"));

                    b.Property<string>("DsMaterial")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_MATERIAL");

                    b.Property<double>("DsPrice")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("DS_PRICE");

                    b.Property<double>("DsSize")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("DS_SIZE");

                    b.Property<int?>("SolarPanelTypeIdSolarPanelType")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("IdSolarPanel");

                    b.HasIndex("SolarPanelTypeIdSolarPanelType");

                    b.ToTable("T_TZ_SOLAR_PANEL");
                });

            modelBuilder.Entity("APITechZap.Models.SolarPanelType", b =>
                {
                    b.Property<int>("IdSolarPanelType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_SOLAR_PANEL_TYPE");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSolarPanelType"));

                    b.Property<string>("DsCellType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_CELL_TYPE");

                    b.Property<double>("DsCostPerWatts")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("DS_COST_PER_WATTS");

                    b.Property<string>("DsManufacturer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_MANUFACTURER");

                    b.Property<string>("DsModel")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_MODEL");

                    b.Property<int>("DsProductWarranty")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("DS_PRODUCT_WARRANTY");

                    b.Property<string>("DsVoltage")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_VOLTAGE");

                    b.HasKey("IdSolarPanelType");

                    b.ToTable("T_TZ_SOLAR_PANEL_TYPE");
                });

            modelBuilder.Entity("APITechZap.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USER");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("DsEmail")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_EMAIL");

                    b.Property<string>("DsName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_NAME");

                    b.Property<string>("DsPassword")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_PASSWORD");

                    b.Property<string>("DsSurname")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_SURNAME");

                    b.Property<string>("DsUidFirebase")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_UID_FB");

                    b.Property<DateTime>("DtCreatedAt")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_CREATED_AT");

                    b.Property<DateTime?>("DtDeletedAt")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_DELETED_AT");

                    b.Property<DateTime?>("DtUpdatedAt")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_UPDATED_AT");

                    b.HasKey("IdUser");

                    b.ToTable("T_TZ_USER");
                });

            modelBuilder.Entity("APITechZap.Models.UserAdditionalData", b =>
                {
                    b.Property<int>("IdUserAdditionalData")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USER_ADDITIONAL_DATA");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUserAdditionalData"));

                    b.Property<string>("DsCPF")
                        .HasMaxLength(14)
                        .HasColumnType("NVARCHAR2(14)")
                        .HasColumnName("DS_CPF");

                    b.Property<string>("DsPhone")
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)")
                        .HasColumnName("DS_PHONE");

                    b.Property<DateTime?>("DtBirthDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_BIRTH_DATE");

                    b.Property<DateTime>("DtCreatedAt")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_CREATED_AT");

                    b.Property<DateTime?>("DtUpdatedAt")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_UPDATED_AT");

                    b.Property<int>("IdUser")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USER");

                    b.HasKey("IdUserAdditionalData");

                    b.HasIndex("IdUser")
                        .IsUnique();

                    b.ToTable("T_TZ_USER_ADDITIONAL_DATA");
                });

            modelBuilder.Entity("APITechZap.Models.WindTurbine", b =>
                {
                    b.Property<int>("IdWindTurbine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_WIND_TURBINE");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdWindTurbine"));

                    b.Property<string>("DsMaterial")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_MATERIAL");

                    b.Property<double?>("DsPrice")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("DS_PRICE");

                    b.Property<double?>("DsSize")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("DS_SIZE");

                    b.Property<int?>("ID_WIND_TURBINE_TYPE")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("IdWindTurbine");

                    b.HasIndex("ID_WIND_TURBINE_TYPE");

                    b.ToTable("T_TZ_WIND_TURBINE");
                });

            modelBuilder.Entity("APITechZap.Models.WindTurbineType", b =>
                {
                    b.Property<int>("IdWindTurbineType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_WIND_TURBINE_TYPE");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdWindTurbineType"));

                    b.Property<string>("DsGeneratorType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_GENERATOR_TYPE");

                    b.Property<string>("DsManufacturer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_MANUFACTURER");

                    b.Property<string>("DsModel")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_MODEL");

                    b.Property<string>("DsVoltage")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DS_VOLTAGE");

                    b.Property<int>("DsWarrantyYears")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("DS_WARRANTY_YEARS");

                    b.HasKey("IdWindTurbineType");

                    b.ToTable("T_TZ_WIND_TURBINE_TYPE");
                });

            modelBuilder.Entity("APITechZap.Models.Address", b =>
                {
                    b.HasOne("APITechZap.Models.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("APITechZap.Models.Address", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("APITechZap.Models.ContractedPlan", b =>
                {
                    b.HasOne("APITechZap.Models.SolarPanel", "SolarPanel")
                        .WithOne()
                        .HasForeignKey("APITechZap.Models.ContractedPlan", "IdSolarPanel");

                    b.HasOne("APITechZap.Models.User", "User")
                        .WithMany("ContractedPlans")
                        .HasForeignKey("IdUser");

                    b.HasOne("APITechZap.Models.WindTurbine", "WindTurbine")
                        .WithOne()
                        .HasForeignKey("APITechZap.Models.ContractedPlan", "IdWindTurbine");

                    b.Navigation("SolarPanel");

                    b.Navigation("User");

                    b.Navigation("WindTurbine");
                });

            modelBuilder.Entity("APITechZap.Models.SolarPanel", b =>
                {
                    b.HasOne("APITechZap.Models.SolarPanelType", "SolarPanelType")
                        .WithMany()
                        .HasForeignKey("SolarPanelTypeIdSolarPanelType");

                    b.Navigation("SolarPanelType");
                });

            modelBuilder.Entity("APITechZap.Models.UserAdditionalData", b =>
                {
                    b.HasOne("APITechZap.Models.User", "User")
                        .WithOne("UserAdditionalData")
                        .HasForeignKey("APITechZap.Models.UserAdditionalData", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("APITechZap.Models.WindTurbine", b =>
                {
                    b.HasOne("APITechZap.Models.WindTurbineType", "WindTurbineType")
                        .WithMany()
                        .HasForeignKey("ID_WIND_TURBINE_TYPE");

                    b.Navigation("WindTurbineType");
                });

            modelBuilder.Entity("APITechZap.Models.User", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("ContractedPlans");

                    b.Navigation("UserAdditionalData");
                });
#pragma warning restore 612, 618
        }
    }
}
