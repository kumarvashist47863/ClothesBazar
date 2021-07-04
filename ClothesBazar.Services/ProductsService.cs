using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothesBazar.Entities;
using ClothesBazar.Database;


namespace ClothesBazar.Services
{
   public  class ProductsService
    {
        /// <summary>
        /// SK: Get particualr category from DB
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Product GetProduct(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Products.Find(ID);
            }
        }

        /// <summary>
        /// SK: This method is used to get all Product from DB
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProduct()
        {
            using (var context = new CBContext())
            {
                return context.Products.ToList();
            }
        }

        /// <summary>
        /// SK: Save Product record in database
        /// </summary>
        /// <param name="product"></param>
        public void SaveProduct(Product product)
        {
            using (var context = new CBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// SK: Update Product in database
        /// </summary>
        /// <param name="Products"></param>
        public void UpdateProduct(Product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// SK: delete product in database
        /// </summary>
        /// <param name="product"></param>
        public void DeleteProduct(int ID)
        {
            using (var context = new CBContext())
            {
                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();

            }
        }
    }
}
