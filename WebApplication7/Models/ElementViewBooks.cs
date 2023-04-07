using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication7.Models
{
    public class ElementViewBooks
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
