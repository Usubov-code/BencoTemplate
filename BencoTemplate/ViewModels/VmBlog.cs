using BencoTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.ViewModels
{
    public class VmBlog
    {
        public List<Blog> Blogs { get; set; }
        public List<CustomUser> CustomUsers { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
