using BencoTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BencoTemplate.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slide> Slides { get; set; }

        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }

    }
}
