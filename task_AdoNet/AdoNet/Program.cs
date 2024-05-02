using AdoNet.Controllers;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;

            ProductController productController = new ProductController();

            do
            {
                Console.WriteLine("\nMenu:\n");
                Console.WriteLine("1.Create product\n2.Delete product\n3.Get single product\n4.Get all products\n5.Update product\n0.Exit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        productController.AddProduct();
                        break;


                    case "2":
                        productController.DeleteProduct();
                        break;


                    case "3":
                        productController.GetProduct();
                        break;

                    case "4":
                        productController.GetAllProducts();
                        break;

                    case "5":
                        productController.UpdateProduct();
                        break;

                    default:
                        Console.WriteLine("Choice is incorrect. Try again...");
                        break;
                }
            } while (choice != "0");
        }
    }
}
