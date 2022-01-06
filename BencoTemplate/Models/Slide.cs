using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class Slide
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }


        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(100)]
        public string Logo { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public List<Home> Homes { get; set; }

    }
}
