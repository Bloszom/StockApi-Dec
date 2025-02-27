﻿using System.ComponentModel.DataAnnotations;
using morningclassonapi.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace morningclassonapi.DTO.Account
{
    public class CreateStockDTO
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol can not be more than 10 characters")]
        public string? Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(20, ErrorMessage = "Symbol can not be more than 20 characters")]
        public string? CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal Lastdiv { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be nore than 10 characters" )]
        public string Industry { get; set; } = string.Empty;


        [Required]
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }

       
    }
}
