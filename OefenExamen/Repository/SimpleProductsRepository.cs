using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OefenExamen.DomainClasses;
using OefenExamen.DataLayer;
using System.Data.Entity;

namespace Repository
{
    public class SimpleProductsRepository
    {
        public List<Products> GetProducts()
        {
            //List<Products> ProductsList = new List<Products>();
            using (var context = new OefenExamenModel())
            {
                var ProductsList = context.Products.Include("Categories").ToList();
                return ProductsList;
            }


        }

       public Products GetProductById(string id)
       {
            using (var context = new OefenExamenModel())
            {
                var details = context.Products.Include("Categories").First(c => c.ProductID == id);
                return details;
            }

        }


      //  public Products GetProductsById(int id)
      //  {
      //      Products Products;
      //      using (var context = new OefenExamenModel())
      //      {
      //          //Products = context.Products.Include("ContactDetail").Where(c => c.ProductsId == id).First();
      //      }
      //      return Products;

      //  }

      //  public void UpdateProducts(Products Products)
      //  {
      //      using (var context = new OefenExamenModel())
      //      {
      //          //var cust = context.Products.FirstOrDefault(c => c.ProductsId == Products.ProductsId);
      //          //cust.FirstName = Products.FirstName;
      //          //Products.LastName = Products.LastName;
      //          //cust.DateOfBirth = Products.DateOfBirth;
      //          //context.SaveChanges();
      //      }
      //  }

      //  public void AddNewProducts(Products Products)
      //  {
      //      using (var context = new OefenExamenModel())
      //      {
      //          //context.Productss.Add(Products);
      //          //context.SaveChanges();
      //      }
      //  }

      //  public void DeleteProducts(int id)
      //  {
      //      using (var context = new OefenExamenModel())
      //      {
      //          //var Products = context.Productss.Find(id);
      //          //context.Productss.Remove(Products);
      //          //context.SaveChanges();
      //      }
      //  }
      }
    }
