using CrmApp.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CrmApp.Services
{
    public class ProductManagment
    {
        private CrmDbContext db;

        public ProductManagment(CrmDbContext _db)
        {
            db = _db;
        }

        //CRUD = Create / Read / Update / Delete : Methods

        public Product CreateProduct(ProductOption po)
        {
            Product product = new Product()
            {
                Name = po.Name,
                Price = po.Price,
                Quantity = po.Quantity
            };

            db.Products.Add(product);
            db.SaveChanges();

            return product;
        }

        public Product FindProductById(int id)
        {

            Product product = db.Products.Find(id);
            return product;
        }

        public Product UpdateProduct(ProductOption po, int id)
        {
            Product product = db.Products.Find(id);

            if (po.Name != null)
                product.Name = po.Name;
            if (po.Price > 0)
                product.Price = po.Price;
            if (po.Quantity > 0)
                product.Quantity = po.Quantity;

            db.SaveChanges();

            return product;
        }

        public bool DeleteProdcutById(int id)
        {
            Product product = db.Products.Find(id);

            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
