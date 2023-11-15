using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsoild
{
    internal class ProductManager
    {
        private List<IProduct> products;

        public ProductManager()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public void RemoveProduct(IProduct product)
        {
            products.Remove(product);
            Console.WriteLine("Product removed successfully.");
        }

        public void UpdateProduct(IProduct product)
        {
            Console.WriteLine("Please enter the new modifications for the product.");

            // Prompt the user to enter the updated values
            Console.Write("Product Name: ");
            string newName = Console.ReadLine();

            Console.Write("Creation Date: ");
            DateTime newCreationDate = DateTime.Parse(Console.ReadLine());

            // Update the product properties
            product.Name = newName;
            product.CreationDate = newCreationDate;

            Console.WriteLine("Product updated successfully.");
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Product list:");

            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
            }
            else
            {
                foreach (var product in products)
                {
                    product.DisplayDetails();
                }
            }
        }

        public IProduct GetProductByName(string productName)
        {
            return products.FirstOrDefault(p => p.Name == productName);
        }
    }
}