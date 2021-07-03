using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothesBazar.Entities;
using ClothesBazar.Database;

namespace ClothesBazar.Services
{
    public class CategoriesServices
    {

        /// <summary>
        /// SK: Get particualr category from DB
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Category GetCategory(int ID)
        {
            using (var context= new CBContext())
            {
                return context.Categories.Find(ID);
            }
        }

        /// <summary>
        /// SK: This method is used to get all categories from DB
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategories()
        {
            using (var context = new CBContext())
            {
                return context.Categories.ToList();
            }
        }

        /// <summary>
        /// SK: Save Category record in database
        /// </summary>
        /// <param name="category"></param>
        public void SaveCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// SK: Update Category in database
        /// </summary>
        /// <param name="category"></param>
        public void UpdateCategory(Category category)
        {
            using (var context=new CBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// SK: delete Category in database
        /// </summary>
        /// <param name="category"></param>
        public void DeleteCategory(int ID)
        {
            using (var context = new CBContext())
            {
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();

            }
        }


    }
}
