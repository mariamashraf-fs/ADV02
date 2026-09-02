using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10.Classes
{
    public static class TransformService
    {
        // Func<Product, string> is used because we need to convert each Product into a string and return the result,
        // unlike Action which doesn't return anything.
        public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        {
            List<string> result = new List<string>();

            foreach (Product product in products)
            {
                result.Add(transform(product));
            }

            return result;
        }
    }
}
