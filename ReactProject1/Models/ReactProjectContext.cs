using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReactProject1.Models;

public partial class ReactProjectContext : DbContext
{
    public ReactProjectContext()
    {
    }

    public ReactProjectContext(DbContextOptions<ReactProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApplicationMaster> ApplicationMasters { get; set; }

    public virtual DbSet<Lead> Leads { get; set; }

    public virtual DbSet<LoanTypeMapping> LoanTypeMappings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=ReactProject;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationMaster>(entity =>
        {
            entity.ToTable("ApplicationMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstanceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubCategory)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity.Property(e => e.LeadId).ValueGeneratedNever();
            entity.Property(e => e.AddressLine3).HasMaxLength(50);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.ApplicableFor)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.BaseCurrency)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CityOfBirth).HasMaxLength(100);
            entity.Property(e => e.Community).HasMaxLength(100);
            entity.Property(e => e.CompanyCin)
                .HasMaxLength(50)
                .HasColumnName("CompanyCIN");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(200)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerTaxResidentType).HasMaxLength(100);
            entity.Property(e => e.CustomerType)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DocumentTypeSubmitted)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Dsacode)
                .HasMaxLength(50)
                .HasColumnName("DSACode");
            entity.Property(e => e.FatherName).HasMaxLength(250);
            entity.Property(e => e.FlagCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IncorporationCountry)
                .HasMaxLength(100)
                .HasColumnName("Incorporation_Country");
            entity.Property(e => e.InstanceGuid)
                .HasMaxLength(50)
                .HasColumnName("InstanceGUID");
            entity.Property(e => e.InstituteName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IsBalanceTransfer)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KyctypeData)
                .IsUnicode(false)
                .HasColumnName("KYCTypeData");
            entity.Property(e => e.Landmark).HasMaxLength(50);
            entity.Property(e => e.LastAction).HasColumnType("datetime");
            entity.Property(e => e.LeadCaste).HasMaxLength(100);
            entity.Property(e => e.LeadCreatedBy).HasMaxLength(50);
            entity.Property(e => e.LeadDependents).HasMaxLength(50);
            entity.Property(e => e.LeadDnd)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("LeadDND");
            entity.Property(e => e.LeadDob)
                .HasMaxLength(50)
                .HasColumnName("LeadDOB");
            entity.Property(e => e.LeadEmail).HasMaxLength(100);
            entity.Property(e => e.LeadEntityType).HasMaxLength(50);
            entity.Property(e => e.LeadForm60)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadGender).HasMaxLength(50);
            entity.Property(e => e.LeadGuid)
                .HasMaxLength(50)
                .HasColumnName("LeadGUID");
            entity.Property(e => e.LeadLoanType).HasMaxLength(200);
            entity.Property(e => e.LeadLocation).HasMaxLength(50);
            entity.Property(e => e.LeadMaritalStatus).HasMaxLength(50);
            entity.Property(e => e.LeadName).HasMaxLength(250);
            entity.Property(e => e.LeadNamePrefix).HasMaxLength(5);
            entity.Property(e => e.LeadNationality)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LeadPan)
                .HasMaxLength(50)
                .HasColumnName("LeadPAN");
            entity.Property(e => e.LeadPhone).HasMaxLength(15);
            entity.Property(e => e.LeadPincode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LeadProfessionType).HasMaxLength(50);
            entity.Property(e => e.LeadReligion).HasMaxLength(50);
            entity.Property(e => e.LeadResidentStatus).HasMaxLength(50);
            entity.Property(e => e.LeadState).HasMaxLength(100);
            entity.Property(e => e.LeadStatus).HasMaxLength(50);
            entity.Property(e => e.LeadSubLoanType).HasMaxLength(200);
            entity.Property(e => e.LeadToken).HasMaxLength(100);
            entity.Property(e => e.LeadUid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LeadUID");
            entity.Property(e => e.LoanBranch).HasMaxLength(50);
            entity.Property(e => e.LoanFlags)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MotherName).HasMaxLength(250);
            entity.Property(e => e.OnBoardingStage).HasMaxLength(100);
            entity.Property(e => e.ParentCountry)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(100);
            entity.Property(e => e.PreferredLanguage)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Qualification).HasMaxLength(150);
            entity.Property(e => e.ResidingSince).HasColumnType("datetime");
            entity.Property(e => e.Scheme).HasMaxLength(100);
            entity.Property(e => e.SourcingOfficerId)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.SourcingType).HasMaxLength(50);
            entity.Property(e => e.StaffId)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TargetChannel).HasMaxLength(50);
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoanTypeMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanTypeMapping");

            entity.Property(e => e.EntityType).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InstanceId).HasMaxLength(250);
            entity.Property(e => e.LoanTypeCode)
                .HasMaxLength(250)
                .HasColumnName("Loan_Type_Code");
            entity.Property(e => e.LoanTypeName).HasMaxLength(250);
            entity.Property(e => e.ProductName).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
