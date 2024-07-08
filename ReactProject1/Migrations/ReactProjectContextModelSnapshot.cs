﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactProject1.Models;

#nullable disable

namespace ReactProject1.Migrations
{
    [DbContext(typeof(ReactProjectContext))]
    partial class ReactProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReactProject1.Models.Lead", b =>
                {
                    b.Property<int>("LeadId")
                        .HasColumnType("int");

                    b.Property<string>("AddressLine3")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AddressType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ApplicableFor")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("BaseCurrency")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("CityOfBirth")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Community")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyCin")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CompanyCIN");

                    b.Property<string>("CustomerId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("CustomerID");

                    b.Property<string>("CustomerTaxResidentType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CustomerType")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("DocumentTypeSubmitted")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Dsacode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DSACode");

                    b.Property<string>("FatherName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FlagCode")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("IncorporationCountry")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Incorporation_Country");

                    b.Property<string>("InstanceGuid")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("InstanceGUID");

                    b.Property<string>("InstituteName")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("IsBalanceTransfer")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("IsMultiSubDealer")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMultiple")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsQuickEligibility")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsStaff")
                        .HasColumnType("bit");

                    b.Property<string>("KyctypeData")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("KYCTypeData");

                    b.Property<string>("Landmark")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("LastAction")
                        .HasColumnType("datetime");

                    b.Property<string>("LeadCaste")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LeadCreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadDependents")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadDnd")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("LeadDND")
                        .IsFixedLength();

                    b.Property<string>("LeadDob")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LeadDOB");

                    b.Property<string>("LeadEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LeadEntityType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadForm60")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LeadGender")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadGuid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LeadGUID");

                    b.Property<int>("LeadLastScreen")
                        .HasColumnType("int");

                    b.Property<string>("LeadLoanType")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LeadLocation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadMaritalStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LeadNamePrefix")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("LeadNationality")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("LeadPan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LeadPAN");

                    b.Property<string>("LeadPhone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LeadPincode")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("LeadProfessionType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadReligion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadResidentStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("LeadStage")
                        .HasColumnType("int");

                    b.Property<string>("LeadState")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LeadStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LeadSubLoanType")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LeadToken")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LeadUid")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("LeadUID");

                    b.Property<string>("LoanBranch")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LoanFlags")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<bool?>("MailingAddress")
                        .HasColumnType("bit");

                    b.Property<string>("MotherName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OnBoardingStage")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ParentCountry")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("PlaceOfBirth")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PreferredLanguage")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Qualification")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResidingSince")
                        .HasColumnType("datetime");

                    b.Property<string>("Scheme")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("SourceChannelId")
                        .HasColumnType("int");

                    b.Property<string>("SourcingOfficerId")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.Property<string>("SourcingType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StaffId")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.Property<string>("TargetChannel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserType")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("LeadId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("ReactProject1.Models.LoanTypeMapping", b =>
                {
                    b.Property<string>("EntityType")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InstanceId")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LoanTypeCode")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Loan_Type_Code");

                    b.Property<int?>("LoanTypeId")
                        .HasColumnType("int");

                    b.Property<string>("LoanTypeName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.ToTable("LoanTypeMapping", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
