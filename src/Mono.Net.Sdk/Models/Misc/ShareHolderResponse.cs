using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Misc
{
    public class ShareholderResponse
    {
       [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("otherName")]
        public string OtherName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("formerNationality")]
        public string FormerNationality { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        [JsonProperty("formerName")]
        public string FormerName { get; set; }

        [JsonProperty("corporationName")]
        public string CorporationName { get; set; }

        [JsonProperty("rcNumber")]
        public string RcNumber { get; set; }

        [JsonProperty("corporationCompany")]
        public CorporationCompany CorporationCompany { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("accreditationnumber")]
        public string Accreditationnumber { get; set; }

        [JsonProperty("formType")]
        public string FormType { get; set; }

        [JsonProperty("numSharesAlloted")]
        public string NumSharesAlloted { get; set; }

        [JsonProperty("typeOfShares")]
        public string TypeOfShares { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("dateOfAppointment")]
        public string DateOfAppointment { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("formerSurname")]
        public string FormerSurname { get; set; }

        [JsonProperty("formerFirstName")]
        public string FormerFirstName { get; set; }

        [JsonProperty("formerOtherName")]
        public string FormerOtherName { get; set; }

        [JsonProperty("identityNumber")]
        public string IdentityNumber { get; set; }

        [JsonProperty("otherDirectorshipDetails")]
        public string OtherDirectorshipDetails { get; set; }

        [JsonProperty("affiliateTypeFk")]
        public AffiliateTypeFk AffiliateTypeFk { get; set; }

        [JsonProperty("countryFk")]
        public CountryFk CountryFk { get; set; }

        [JsonProperty("lga")]
        public string Lga { get; set; }

        [JsonProperty("isCorporate")]
        public string IsCorporate { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }

        [JsonProperty("isChairman")]
        public string IsChairman { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("formerNameType")]
        public string FormerNameType { get; set; }

        [JsonProperty("affiliatesResidentialAddress")]
        public string AffiliatesResidentialAddress { get; set; }

        [JsonProperty("affiliatesPscInformation")]
        public string AffiliatesPscInformation { get; set; }

        [JsonProperty("isPublicUser")]
        public string IsPublicUser { get; set; }
    }

    public class CorporationCompany
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("approvedName")]
        public string ApprovedName { get; set; }

        [JsonProperty("stringives")]
        public string stringives { get; set; }

        [JsonProperty("registrationApproved")]
        public string RegistrationApproved { get; set; }

        [JsonProperty("rcNumber")]
        public string RcNumber { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("branchAddress")]
        public string BranchAddress { get; set; }

        [JsonProperty("registrationSubmitted")]
        public string RegistrationSubmitted { get; set; }

        [JsonProperty("businessCommencementDate")]
        public string BusinessCommencementDate { get; set; }

        [JsonProperty("reservationSerialNo")]
        public string ReservationSerialNo { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("registrationSerialNo")]
        public string RegistrationSerialNo { get; set; }

        [JsonProperty("registrationApprovedByRg")]
        public string RegistrationApprovedByRg { get; set; }

        [JsonProperty("trackingId")]
        public string TrackingId { get; set; }

        [JsonProperty("dateOfReservation")]
        public string DateOfReservation { get; set; }

        [JsonProperty("needsProficiencyDocs")]
        public string NeedsProficiencyDocs { get; set; }

        [JsonProperty("availabilityCode")]
        public string AvailabilityCode { get; set; }

        [JsonProperty("nameAvailability")]
        public string NameAvailability { get; set; }

        [JsonProperty("forwardedToAo")]
        public string ForwardedToAo { get; set; }

        [JsonProperty("forwardedToRgs")]
        public string ForwardedToRgs { get; set; }

        [JsonProperty("classificationFk")]
        public string ClassificationFk { get; set; }

        [JsonProperty("natureOfBusinessFk")]
        public string NatureOfBusinessFk { get; set; }

        [JsonProperty("companyTypeFk")]
        public string CompanyTypeFk { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("review_status")]
        public string ReviewStatus { get; set; }

        [JsonProperty("isOldRecord")]
        public string IsOldRecord { get; set; }

        [JsonProperty("regPortalUserFk")]
        public string RegPortalUserFk { get; set; }

        [JsonProperty("approvedNameForSearch")]
        public string ApprovedNameForSearch { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("companyStatus")]
        public string CompanyStatus { get; set; }

        [JsonProperty("isForChangeOfName")]
        public string IsForChangeOfName { get; set; }

        [JsonProperty("isChangeOfNameSubmited")]
        public string IsChangeOfNameSubmited { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("isSubmittedForPostInc")]
        public string IsSubmittedForPostInc { get; set; }

        [JsonProperty("queryCode")]
        public string QueryCode { get; set; }

        [JsonProperty("queryHistoryFk")]
        public string QueryHistoryFk { get; set; }

        [JsonProperty("reasonForDisapproval")]
        public string ReasonForDisapproval { get; set; }

        [JsonProperty("dateOfApproval")]
        public string DateOfApproval { get; set; }

        [JsonProperty("date_of_query")]
        public string DateOfQuery { get; set; }

        [JsonProperty("approver")]
        public string Approver { get; set; }

        [JsonProperty("updatingOffice")]
        public string UpdatingOffice { get; set; }

        [JsonProperty("hasBeenUpdated")]
        public string HasBeenUpdated { get; set; }

        [JsonProperty("dateOfUpdate")]
        public string DateOfUpdate { get; set; }

        [JsonProperty("approvedForUpdate")]
        public string ApprovedForUpdate { get; set; }

        [JsonProperty("dateOfUpdateApproval")]
        public string DateOfUpdateApproval { get; set; }

        [JsonProperty("approvedForUpdateByFk")]
        public string ApprovedForUpdateByFk { get; set; }

        [JsonProperty("updatedByFk")]
        public string UpdatedByFk { get; set; }

        [JsonProperty("registrationSubmissionDate")]
        public string RegistrationSubmissionDate { get; set; }

        [JsonProperty("financialYearEnd")]
        public string FinancialYearEnd { get; set; }

        [JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }

        [JsonProperty("lga")]
        public string Lga { get; set; }

        [JsonProperty("delisting_status")]
        public string DelistingStatus { get; set; }

        [JsonProperty("head_office_address")]
        public string HeadOfficeAddress { get; set; }

        [JsonProperty("companyHeadOffice")]
        public string CompanyHeadOffice { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("progressLevel")]
        public string ProgressLevel { get; set; }

        [JsonProperty("batch")]
        public string Batch { get; set; }

        [JsonProperty("queried")]
        public string Queried { get; set; }

        [JsonProperty("firsTin")]
        public string FirsTin { get; set; }

        [JsonProperty("natureOfBusiness")]
        public string NatureOfBusiness { get; set; }

        [JsonProperty("formerName")]
        public string FormerName { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("durationInQueue")]
        public string DurationInQueue { get; set; }

        [JsonProperty("timeTakeTobeProcessed")]
        public string TimeTakeTobeProcessed { get; set; }

        [JsonProperty("rrr")]
        public string Rrr { get; set; }

        [JsonProperty("paymentDate")]
        public string PaymentDate { get; set; }

        [JsonProperty("enteredBy")]
        public string EnteredBy { get; set; }

        [JsonProperty("activeForPostInc")]
        public string ActiveForPostInc { get; set; }

        [JsonProperty("shareCapital")]
        public string ShareCapital { get; set; }

        [JsonProperty("shareCapitalInWords")]
        public string ShareCapitalInWords { get; set; }

        [JsonProperty("dividedInto")]
        public string DividedInto { get; set; }

        [JsonProperty("ofEach")]
        public string OfEach { get; set; }

        [JsonProperty("consentCode")]
        public string ConsentCode { get; set; }

        [JsonProperty("jtbTINStatus")]
        public string JtbTINStatus { get; set; }

        [JsonProperty("fullAddress")]
        public string FullAddress { get; set; }
    }

    public  class AffiliateTypeFk
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
    
    public class CountryFk
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
    
     
}