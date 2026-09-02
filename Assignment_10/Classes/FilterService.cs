using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10.Classes
{
    public static class FilterService
    {
        // Predicate<Product> is used because it is the built-in delegate specifically designed
        // for conditions that return (true or false) for a single item.
        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
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
