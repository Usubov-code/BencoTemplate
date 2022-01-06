using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Adress { get; set; }
        [MaxLength(100)]
        public string WorkTime { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
    }
}
