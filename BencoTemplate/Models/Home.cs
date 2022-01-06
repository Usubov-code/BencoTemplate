using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }


        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
      
        [MaxLength(500)]
        public string Description { get; set; }
        [MinLength(150)]
        public string Icon { get; set; }

        [MinLength(150)]
        public string IconTitle { get; set; }
        [MinLength(150)]
        public string IconDescription { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [ForeignKey("Slide")]
        public int SlideId { get; set; }
        public Slide Slide { get; set; }
    }
}
