using System.ComponentModel.DataAnnotations.Schema;

namespace roofstock.Data.Entities
{
    public class Property
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int PropertyID { get; set; }

        [Column(TypeName = "decimal(19,10)")]
        public decimal? ListPrice { get; set; }

        [Column(TypeName = "decimal(19,10)")]
        public decimal? MonthlyRent { get; set; }

        public int? YearBuilt { get; set; }
        public Address Address { get; set; }
    }
}