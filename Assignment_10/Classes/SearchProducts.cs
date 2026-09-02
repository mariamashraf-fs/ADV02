using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10.Classes
{
    public static class SearchService
    {
        // Func<Product, bool> is used because the filter receives a Product and returns true or false
        // to determine whether it should be included.
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> condition)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (condition(product))
                {
                    result.Add(product);
                }
            }

            return result;
        }
    }

}   
