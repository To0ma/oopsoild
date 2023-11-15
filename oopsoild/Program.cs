using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsoild
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            while (true)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Select the desired action:");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Remove Product");
                Console.WriteLine("5. Exit");
                Console.WriteLine("=============================");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        productManager.DisplayProducts();
                        break;
                    case "2":
                        AddProduct(productManager);
                        break;
                    case "3":
                        UpdateProduct(productManager);
                        break;
                    case "4":
                        RemoveProduct(productManager);
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddProduct(ProductManager productManager)
        {
            Console.WriteLine("Add a new product:");
            Console.WriteLine("Select the product type:");
            Console.WriteLine("1. Health Product");
            Console.WriteLine("2. Food Product");
            Console.WriteLine("3. Clothes Product");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    HealthProduct healthProduct = new HealthProduct();
                    Console.Write("Enter the product name: ");
                    healthProduct.Name = Console.ReadLine();
                    Console.Write("Enter the creation date (YYYY-MM-DD): ");
                    healthProduct.CreationDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter the health property: ");
                    healthProduct.HealthProperty = Console.ReadLine();
                    productManager.AddProduct(healthProduct);
                    break;
                case "2":
                    FoodProduct foodProduct = new FoodProduct();
                    Console.Write("Enter the product name: ");
                    foodProduct.Name = Console.ReadLine();
                    Console.Write("Enter the creation date (YYYY-MM-DD): ");
                    foodProduct.CreationDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter the expiration date: ");
                    foodProduct.ExpirationDate = Console.ReadLine();
                    productManager.AddProduct(foodProduct);
                    break;
                case "3":
                    ClothesProduct clothesProduct = new ClothesProduct();
                    Console.Write("Enter the product name: ");
                    clothesProduct.Name = Console.ReadLine();
                    Console.Write("Enter the creation date (YYYY-MM-DD): ");
                    clothesProduct.CreationDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter the size: ");
                    clothesProduct.Size = Console.ReadLine();
                    productManager.AddProduct(clothesProduct);
                    break;
                default:
                    Console.WriteLine("Invalid type. Please try again.");
                    break;
            }
        }

        static void UpdateProduct(ProductManager productManager)
        {
            Console.WriteLine("Update Product:");
            Console.WriteLine("Enter the name of the product you want to update:");
            string productName = Console.ReadLine();

            IProduct product = productManager.GetProductByName(productName);

            if (product == null)
            {
                Console.WriteLine("The product does not exist.");
                return;
            }

            Console.WriteLine("Please enter the new modifications to the product:");
            productManager.UpdateProduct(product);
        }

        static void RemoveProduct(ProductManager productManager)
        {
            Console.WriteLine("Remove Product:");
            Console.WriteLine("Enter the name of the product you want to remove:");
            string productName = Console.ReadLine();

            IProduct product = productManager.GetProductByName(productName);

            if (product == null)
            {
                Console.WriteLine("The product does not exist.");
                return;
            }

            productManager.RemoveProduct(product);
        }
    }
}