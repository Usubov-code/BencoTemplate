using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Content { get; set; }
        [MaxLength(150)]
        public string Img { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(150)]
        public string Icon { get; set; }
        [MaxLength(150)]
        public string IconTitle { get; set; }
        [MaxLength(100)]
        public string IconNumber { get; set; }
    }
}
