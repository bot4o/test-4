﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace WebApplication7.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        [Required]
        public double Price { get; set; }
        public string YearOfPublication { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
