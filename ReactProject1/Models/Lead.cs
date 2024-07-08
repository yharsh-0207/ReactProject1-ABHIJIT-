using System;
using System.Collections.Generic;

namespace ReactProject1.Models;

public partial class Lead
{
    public int LeadId { get; set; }

    public string? LeadNamePrefix { get; set; }

    public string? LeadName { get; set; }

    public string? LeadPan { get; set; }

    public string LeadEntityType { get; set; } = null!;

    public string? LeadProfessionType { get; set; }

    public string? LeadLoanType { get; set; }

    public string? LeadSubLoanType { get; set; }

    public string? LeadEmail { get; set; }

    public string? LeadPhone { get; set; }

    public string? LeadLocation { get; set; }

    public string? LeadDob { get; set; }

    public string? LeadGender { get; set; }

    public string? LeadMaritalStatus { get; set; }

    public string? LeadResidentStatus { get; set; }

    public string? LeadDependents { get; set; }

    public string? Scheme { get; set; }

    public string LeadToken { get; set; } = null!;

    public int LeadLastScreen { get; set; }

    public string LeadGuid { get; set; } = null!;

    public string? OnBoardingStage { get; set; }

    public string? InstanceGuid { get; set; }

    public string? CustomerId { get; set; }

    public int? SourceChannelId { get; set; }

    public string? TargetChannel { get; set; }

    public string? CompanyCin { get; set; }

    public DateTime? LastAction { get; set; }

    public string? UserType { get; set; }

    public string? DocumentTypeSubmitted { get; set; }

    public string? LeadState { get; set; }

    public string? LeadCaste { get; set; }

    public string? CustomerTaxResidentType { get; set; }

    public string? IncorporationCountry { get; set; }

    public bool? IsMultiple { get; set; }

    public string? IsBalanceTransfer { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? Community { get; set; }

    public string? CityOfBirth { get; set; }

    public string? LeadReligion { get; set; }

    public string? LeadNationality { get; set; }

    public string? ParentCountry { get; set; }

    public string? LeadDnd { get; set; }

    public string? SourcingOfficerId { get; set; }

    public bool? IsStaff { get; set; }

    public string? StaffId { get; set; }

    public string? LoanBranch { get; set; }

    public string? Dsacode { get; set; }

    public string? BaseCurrency { get; set; }

    public string? AddressType { get; set; }

    public bool? MailingAddress { get; set; }

    public string? CustomerType { get; set; }

    public string? PreferredLanguage { get; set; }

    public string? FlagCode { get; set; }

    public string? LoanFlags { get; set; }

    public string? ApplicableFor { get; set; }

    public int? GroupId { get; set; }

    public string? Qualification { get; set; }

    public string? SourcingType { get; set; }

    public string? Landmark { get; set; }

    public string? LeadPincode { get; set; }

    public string? AddressLine3 { get; set; }

    public string? LeadStatus { get; set; }

    public bool? IsQuickEligibility { get; set; }

    public string? Remarks { get; set; }

    public DateTime? ResidingSince { get; set; }

    public string? KyctypeData { get; set; }

    public string? LeadUid { get; set; }

    public string? LeadForm60 { get; set; }

    public string? InstituteName { get; set; }

    public string? LeadCreatedBy { get; set; }

    public int? LeadStage { get; set; }

    public bool? IsMultiSubDealer { get; set; }
}
