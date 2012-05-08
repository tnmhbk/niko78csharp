using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HelloFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProductContext())
            {
                // Add a food category 
                var food = new Category { CategoryId = "FOOD", Name = "Foods" };
                db.Categories.Add(food);
                int recordsAffected = db.SaveChanges();
                Console.WriteLine("Saved {0} entities to the database, press any key to exit.", recordsAffected);
                Console.ReadKey();
            } 
        }
    }

    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }

    public class ProductContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
