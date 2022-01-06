using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Logo { get; set; }

        public List<Home> Homes { get; set; }
    }
}
