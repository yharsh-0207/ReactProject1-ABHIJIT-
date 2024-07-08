using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactProject1.Migrations
{
    /// <inheritdoc />
    public partial class firstcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    LeadId = table.Column<int>(type: "int", nullable: false),
                    LeadNamePrefix = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    LeadName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LeadPAN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadEntityType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeadProfessionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadLoanType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LeadSubLoanType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LeadEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LeadPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    LeadLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadDOB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadGender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadMaritalStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadResidentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadDependents = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Scheme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LeadToken = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LeadLastScreen = table.Column<int>(type: "int", nullable: false),
                    LeadGUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OnBoardingStage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InstanceGUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SourceChannelId = table.Column<int>(type: "int", nullable: true),
                    TargetChannel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyCIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastAction = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DocumentTypeSubmitted = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    LeadState = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LeadCaste = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CustomerTaxResidentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Incorporation_Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsMultiple = table.Column<bool>(type: "bit", nullable: true),
                    IsBalanceTransfer = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Community = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CityOfBirth = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LeadReligion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadNationality = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ParentCountry = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    LeadDND = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SourcingOfficerId = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    IsStaff = table.Column<bool>(type: "bit", nullable: true),
                    StaffId = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    LoanBranch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DSACode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BaseCurrency = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AddressType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MailingAddress = table.Column<bool>(type: "bit", nullable: true),
                    CustomerType = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PreferredLanguage = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FlagCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    LoanFlags = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ApplicableFor = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SourcingType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Landmark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadPincode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsQuickEligibility = table.Column<bool>(type: "bit", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidingSince = table.Column<DateTime>(type: "datetime", nullable: true),
                    KYCTypeData = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LeadUID = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LeadForm60 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstituteName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LeadCreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LeadStage = table.Column<int>(type: "int", nullable: true),
                    IsMultiSubDealer = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.LeadId);
                });

            migrationBuilder.CreateTable(
                name: "LoanTypeMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EntityType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InstanceId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: true),
                    Loan_Type_Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LoanTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "LoanTypeMapping");
        }
    }
}
