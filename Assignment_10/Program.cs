using Assignment_10.Classes;

namespace Assignment_10;
    internal class Program
    {
        static void Main(string[] args)
        {

           List<Product> catalog = new() 
           {
                new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
                new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 },
            };

        #region Task01

        //// 1. All Electronics products
        //List<Product> electronics = SearchService.SearchProducts(catalog, p => p.Category == "Electronics");
        //Console.WriteLine("--- Electronics ---");
        //foreach (Product p in electronics) Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

        //// 2. Products cheaper than $50 
        //List<Product> cheapProducts = SearchService.SearchProducts(catalog, p => p.Price < 50);
        //Console.WriteLine("\n--- Under $50 ---");
        //foreach (Product p in cheapProducts) Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

        //// 3. Products that are in stock (Stock > 0) 
        //List<Product> inStock = SearchService.SearchProducts(catalog, p => p.Stock > 0);
        //Console.WriteLine("\n--- In Stock ---");
        //foreach (Product p in inStock) Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

        //// 4. Clothing products under $100
        //List<Product> cheapClothing = SearchService.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
        //Console.WriteLine("\n--- Clothing Under $100 ---");
        //foreach (Product p in cheapClothing) Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

        #endregion

        #region Task03

        #region Part01

        //// Scenario 1: Short Report
        //Console.WriteLine("--- Short Report ---");
        //ReportService.PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

        //// Scenario 2: Detailed Report
        //Console.WriteLine("\n--- Detailed Report ---");
        //ReportService.PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | " +
        //    $"Stock: {p.Stock}"));

        #endregion

        #endregion
    }
}

