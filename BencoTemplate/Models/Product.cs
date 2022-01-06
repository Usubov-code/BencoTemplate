using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(5),MinLength(1)]
        public int Review { get; set; }

        [MaxLength(250)]
        public string LittleDescription { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MinLength(0)]
        public string Price { get; set; }

        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Size { get; set; }

        [ForeignKey("ProductImage")]
        public int ProductImageId { get; set; }
        public ProductImage  ProductImage { get; set; }

        public List<CategoryToProduct> CategoryToProducts { get; set; }

    }
}
