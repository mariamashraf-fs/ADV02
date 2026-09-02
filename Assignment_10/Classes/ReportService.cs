using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10.Classes
{
    public static class ReportService
    {
        // Action<Product> is used because we only need to perform an action (printing) on each product,
        // without returning any value. The caller decides exactly what/how to print via the lambda.
        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }
    }
}
