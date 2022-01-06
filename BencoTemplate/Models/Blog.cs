using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(150)]
        public string Context { get; set; }
        public DateTime CreatedTime { get; set; }
        [ForeignKey("CustomUser")]
        public int CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }

        public List<TagToBlog> TagToBlogs { get; set; }
    }
}
