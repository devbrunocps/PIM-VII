using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StreamingPlatform.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalValue { get; set; }
        public string PaymentOption { get; set; }
        public string PaymentStatus { get; set; }
        public string SaleStatus { get; set; }

        public Sale()
        {
            Products = new List<Product>();
        }
    }
}
