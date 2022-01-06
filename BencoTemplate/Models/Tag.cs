using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
    }
}
