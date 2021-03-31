using System;
using System.Collections.Generic;

namespace roofstock.Api.Mappers
{
    public class AddressPoco
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string county { get; set; }
        public string district { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string zipPlus4 { get; set; }
    }

    public class FinancialPoco
    {
        public object capRate { get; set; }
        public string occupancy { get; set; }
        public bool? isSection8 { get; set; }
        public DateTime? leaseStartDate { get; set; }
        public DateTime? leaseEndDate { get; set; }
        public decimal? listPrice { get; set; }
        public object salePrice { get; set; }
        public object marketValue { get; set; }
        public object monthlyHoa { get; set; }
        public object monthlyManagementFees { get; set; }
        public decimal monthlyRent { get; set; }
        public object netYield { get; set; }
        public object turnOverFee { get; set; }
        public object rehabCosts { get; set; }
        public object rehabDate { get; set; }
        public decimal? yearlyInsuranceCost { get; set; }
        public decimal? yearlyPropertyTaxes { get; set; }
        public bool? isCashOnly { get; set; }
    }

    public class PhysicalPoco
    {
        public decimal? bathRooms { get; set; }
        public decimal? bedRooms { get; set; }
        public string parcelNumber { get; set; }
        public bool? isPool { get; set; }
        public object lotSize { get; set; }
        public int? squareFeet { get; set; }
        public object stories { get; set; }
        public object units { get; set; }
        public int? yearBuilt { get; set; }
        public object zipYearBuilt { get; set; }
    }

    public class ScorePoco
    {
        public object conditionScore { get; set; }
        public string crimeScore { get; set; }
        public int? neighborhoodScore { get; set; }
        public object overallScore { get; set; }
        public object qualityScore { get; set; }
        public string schoolScore { get; set; }
        public string charterSchoolScore { get; set; }
        public string floodRiskScore { get; set; }
        public object walkabilityScore { get; set; }
    }

    public class ValuationPoco
    {
        public object avmBpoValue { get; set; }
        public object avmBpoAdjValue { get; set; }
        public object avmBpoDate { get; set; }
        public decimal rsAvmValue { get; set; }
        public object rsAvmDate { get; set; }
        public object rsBpoMergeValue { get; set; }
    }

    public class PhotoPoco
    {
        public int id { get; set; }
        public string guid { get; set; }
        public string resourceType { get; set; }
        public bool? isPublic { get; set; }
        public object description { get; set; }
        public string filename { get; set; }
        public object sizeInByte { get; set; }
        public string contentType { get; set; }
        public string url { get; set; }
        public string urlMedium { get; set; }
        public string urlSmall { get; set; }
        public object textContent { get; set; }
    }

    public class FloorPlanPoco
    {
        public int id { get; set; }
        public string guid { get; set; }
        public string resourceType { get; set; }
        public bool? isPublic { get; set; }
        public object description { get; set; }
        public string filename { get; set; }
        public object sizeInByte { get; set; }
        public string contentType { get; set; }
        public string url { get; set; }
        public string urlMedium { get; set; }
        public string urlSmall { get; set; }
        public object textContent { get; set; }
    }

    public class ResourcesPoco
    {
        public List<PhotoPoco> photos { get; set; }
        public List<FloorPlanPoco> floorPlans { get; set; }
        public List<object> threeDRenderings { get; set; }
        public List<object> audios { get; set; }
    }

    public class LeaseSummaryPoco
    {
        public string occupancy { get; set; }
        public object leasingStatus { get; set; }
        public object marketedRent { get; set; }
        public object paymentStatus { get; set; }
        public DateTime? leaseStartDate { get; set; }
        public DateTime? leaseEndDate { get; set; }
        public decimal? monthlyRent { get; set; }
        public object securityDepositAmount { get; set; }
        public object hasPet { get; set; }
        public object petFeeAmount { get; set; }
        public bool? isPetsDeposit { get; set; }
        public object petsDepositAmount { get; set; }
        public bool? isLeaseConcessions { get; set; }
        public bool? isRentersInsuranceRequired { get; set; }
        public bool? isSection8 { get; set; }
        public bool? isTenantBackgroundChecked { get; set; }
        public bool? isTenantIncomeAbove3x { get; set; }
        public object isTenantMayTerminateEarly { get; set; }
        public object isTenantPurchaseOption { get; set; }
    }

    public class UtilitiesOwnershipPoco
    {
        public string electric { get; set; }
        public string gas { get; set; }
        public string water { get; set; }
        public string garbage { get; set; }
        public string pool { get; set; }
        public string landscaping { get; set; }
        public string pestControl { get; set; }
    }

    public class ApplianceOwnershipPoco
    {
        public string refrigerator { get; set; }
        public string dishwasher { get; set; }
        public string washer { get; set; }
        public string dryer { get; set; }
        public string microwave { get; set; }
        public string stove { get; set; }
    }

    public class LeasePoco
    {
        public LeaseSummaryPoco leaseSummary { get; set; }
        public UtilitiesOwnershipPoco utilitiesOwnership { get; set; }
        public ApplianceOwnershipPoco applianceOwnership { get; set; }
    }

    public class GoogleMapOptionPoco
    {
        public bool? hasStreetView { get; set; }
        public int? povHeading { get; set; }
        public int? povPitch { get; set; }
        public decimal? povLatitude { get; set; }
        public decimal? povLongitude { get; set; }
    }

    public class PropertyPoco
    {
        public int id { get; set; }
        public int accountId { get; set; }
        public object buyerAccountId { get; set; }
        public object buyerUserId { get; set; }
        public object externalId { get; set; }
        public object programId { get; set; }
        public bool? isDwellCertified { get; set; }
        public bool? isAllowOffer { get; set; }
        public bool? isAllowPreview { get; set; }
        public bool? isFeatured { get; set; }
        public bool? isRentGuaranteed { get; set; }
        public bool? allowRentGuaranteedOptout { get; set; }
        public bool? isSecuritized { get; set; }
        public bool? isHot { get; set; }
        public bool? isNew { get; set; }
        public bool? isBargain { get; set; }
        public bool isDiligenceVaultUnlocked { get; set; }
        public bool? isPropertyManagerOfferRetain { get; set; }
        public bool? isHoa { get; set; }
        public bool? hasAudio { get; set; }
        public bool? hasDiligenceVaultDocuments { get; set; }
        public int? market { get; set; }
        public int? daysOnMarket { get; set; }
        public decimal? latitude { get; set; }
        public decimal? longitude { get; set; }
        public object propertyName { get; set; }
        public string description { get; set; }
        public object highlights { get; set; }
        public string mainImageUrl { get; set; }
        public object personalProperties { get; set; }
        public object diligenceVaultSummary { get; set; }
        public object featuredReason { get; set; }
        public string status { get; set; }
        public string allowedFundingTypes { get; set; }
        public string allowableSaleTypes { get; set; }
        public string visibility { get; set; }
        public string priceVisibility { get; set; }
        public string propertyType { get; set; }
        public object certificationLevel { get; set; }
        public object escrowClosingDate { get; set; }
        public AddressPoco address { get; set; }
        public FinancialPoco financial { get; set; }
        public PhysicalPoco physical { get; set; }
        public ScorePoco score { get; set; }
        public ValuationPoco valuation { get; set; }
        public ResourcesPoco resources { get; set; }
        public object manager { get; set; }
        public object seller { get; set; }
        public object sellerBroker { get; set; }
        public object hoa { get; set; }
        public LeasePoco lease { get; set; }
        public List<object> diligences { get; set; }
        public GoogleMapOptionPoco googleMapOption { get; set; }
        public object inspectionType { get; set; }
    }

    public class PropertiesPoco
    {
        public List<PropertyPoco> properties { get; set; }
    }
}