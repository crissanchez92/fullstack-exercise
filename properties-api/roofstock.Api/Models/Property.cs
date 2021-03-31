namespace roofstock.Api.Models
{
    public class Property
    {
        public int ID { get; set; }

        public int? PropertyID { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? MonthlyRent { get; set; }
        public decimal? GrossYield => this.MonthlyRent.HasValue && this.ListPrice.HasValue ? this.MonthlyRent * 12 / this.ListPrice : null;
        public int? YearBuilt { get; set; }
        public Address Address { get; set; }
    }
}