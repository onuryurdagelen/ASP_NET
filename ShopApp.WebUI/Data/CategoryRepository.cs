using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                 new Category() { CategoryId =1, Name = "Phones", Description = "The Category of Phone" },
                new Category() { CategoryId =2, Name = "PC", Description = "The Category of PC" },
                new Category() {CategoryId =3, Name = "Laptop", Description = "The Category of Laptop" },
                new Category() {CategoryId =4, Name = "Electronic", Description = "The Category of Electronic" },
            };
        }
        public static List<Category> Categories{ get { return _categories; }}
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }
        public static Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
