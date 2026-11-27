using Assignment20.Contexts;
using Assignment20.Enums;
using Assignment20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment20.MenuMethods
{
    public static class Methods
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("    National Bank - Main Menu    ");
            Console.WriteLine("=================================");
            Console.WriteLine("1) Add a new customer");
            Console.WriteLine("2) Open a new Account for a Customer");
            Console.WriteLine("3) Update Account Status (Activate/Closed)");
            Console.WriteLine("4) Remove an Account from a Customer");
            Console.WriteLine("5) List All Customers (with Accounts)");
            Console.WriteLine("0) Exit");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your choice: ");
        }

        public static void AddNewCustomer(BankSystemContext context)
        {
            var cst = new Customer();
            Console.WriteLine("--- Add New Customer ---");
            while (true)
            {
                Console.Write("Enter Customer FullName: ");
                string name = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Please Enter Customer FullName.");
                else if (int.TryParse(name, out int x))
                    Console.WriteLine("Please Enter Customer FullName Not Numbers.");
                else
                {
                    cst.FullName = name;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter Customer National ID: ");
                var nationalId = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(nationalId))
                    Console.WriteLine("Please Enter Customer National ID.");
                else if (context.Customers.Any(c => c.NationalId == nationalId))
                    Console.WriteLine("A customer with this national ID already exists.");
                else
                {
                    cst.NationalId = nationalId;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter Customer Date Of Birth (yyyy-MM-dd): ");
                var dateOfBirthInput = Console.ReadLine();
                if (DateTime.TryParse(dateOfBirthInput, out DateTime dateOfBirth))
                {
                    cst.DateOfBirth = dateOfBirth;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid date in the format yyyy-MM-dd.");
                }
            }
            while (true)
            {
                Console.Write("Enter Customer Email: ");
                var email = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(email))
                    Console.WriteLine("Please Enter Customer Email.");
                else if (!MailAddress.TryCreate(email, out _))
                    Console.WriteLine("Please enter a valid email address(user@example.com).");
                else
                {
                    cst.Email = email;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter Customer Phone Number: ");
                var phone = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(phone))
                    Console.WriteLine("Please Enter Customer Phone Number.");
                else
                {
                    cst.PhoneNumber = phone;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter Customer Address: ");
                var address = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(address))
                    Console.WriteLine("Please Enter Customer Address.");
                else
                {
                    cst.Address = address;
                    break;
                }
            }
            Console.WriteLine("Enter Customer Type: ");
            Console.WriteLine("\t1) Individual");
            Console.WriteLine("\t2) Business");
            Console.Write("   Choice: ");
            while (true)
            {
                var choice = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(choice) || !int.TryParse(choice, out int customerType))
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    continue;
                }

                if (customerType == 1)
                {
                    cst.CustomerType = CustomerTypeEnum.Individual;
                    break;
                }
                else if (customerType == 2)
                {
                    cst.CustomerType = CustomerTypeEnum.Business;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
            }

            try
            {
                context.Customers.Add(cst);
                context.SaveChanges();
                Console.WriteLine("Customer created successfully!");
                Console.WriteLine("CustomerId: {0}", cst.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the customer: " + ex.Message);
            }
        }
    }
}
