using Day6ExeGenericsRepo.Models;
using Day6ExeGenericsRepo.Repositories;
using System;

namespace Day6ExeGenericsRepo
{
    internal class Program
    {
        static void Main()
        {
            Repository<Product> productRepo = new Repository<Product>();

            productRepo.Add(new Product(1, "Laptop", 1000m));
            productRepo.Add(new Product(2, "Mouse", 20m));
            productRepo.Add(new Product(3, "Clock", 25m));
            productRepo.Add(new Product(4, "Camera", 150m));
            productRepo.Add(new Product(5, "TV", 1025m));

            productRepo.Update(4, new Product(5, "Printer", 210m));
            productRepo.Delete(0);

            Product thisProduct3 = productRepo.Get(3);
            Console.Write($"\n\tProduct ({thisProduct3._id}):" +
                          $" {thisProduct3._name} - ${thisProduct3._price}");

            Console.WriteLine("\n\n\tProducts");
            Console.WriteLine("\t--------");

            foreach (var product in productRepo.GetAll())
            {
                Console.WriteLine($"\t({product._id}) {product._name}" +
                                  $" - ${product._price}");
            }

            Console.WriteLine("\n\t-----------------------------------------");
            Repository<Customer> customerRepo = new Repository<Customer>();
            Customer customer1 = new Customer(1, "Alice", "alice@gmail.com");
            Customer customer2 = new Customer(2, "Bob", "bob@outlook.com");
            Customer customer3 = new Customer(3, "Jane", "jane@yahoo.com");
            Customer customer4 = new Customer(4, "Sally", "sally@gmail.com");
            Customer customer5 = new Customer(5, "Rupert", "rupert@outlook.com");

            customerRepo.Add(customer1);
            customerRepo.Add(customer2);
            customerRepo.Add(customer3);
            customerRepo.Add(customer4);
            customerRepo.Add(customer5);

            customerRepo.Update(4, new Customer(5, "Walter", "walter@yahoo.com"));
            customerRepo.Delete(0);

            Customer thisCustomer3 = customerRepo.Get(3);
            Console.WriteLine($"\n\tCustomer ({thisCustomer3._id})" +
                              $" {thisCustomer3._name} - {thisCustomer3._email}");

            Console.WriteLine("\n\tCustomers");
            Console.WriteLine("\t---------");
            foreach (var customer in customerRepo.GetAll())
            {
                Console.WriteLine($"\t({customer._id}) " +
                                  $"{customer._name} - {customer._email}");
            }

            Console.ReadKey();
        }
    }
}
