using System;

namespace FINLOGIX.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }        
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxRate { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}