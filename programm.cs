using System;
using System.Collections.Generic;
using System.Linq;

namespace TourismManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            List<Tour> tours = new List<Tour>();
            List<Sale> sales = new List<Sale>();

            clients.Add(new Client { Key = 1, FullName = "Iван Iванов", Phone = "+380501234567", PassportNumber = "AB123456", Discount = 5 });
            clients.Add(new Client { Key = 2, FullName = "Олена Петрiвна", Phone = "+380671234567", PassportNumber = "CD654321", Discount = 10 });

            tours.Add(new Tour { Key = 1, Name = "Paris", StartDate = new DateTime(2024, 12, 1), EndDate = new DateTime(2024, 12, 10), City = "Paris", Price = 1500, AvailableQuantity = 5 });
            tours.Add(new Tour { Key = 2, Name = "Rome", StartDate = new DateTime(2024, 11, 25), EndDate = new DateTime(2024, 12, 5), City = "Rome", Price = 1200, AvailableQuantity = 3 });

            sales.Add(new Sale { Key = 1, EmployeeName = "Анна Мельник", TourName = "Paris", QuantitySold = 2 });

            while (true)
            {
                Console.WriteLine("\nОберіть дію:");
                Console.WriteLine("1. Показати інформацію про тури");
                Console.WriteLine("2. Показати клієнтів зi знижками");
                Console.WriteLine("3. Показати найпопулярніший тур");
                Console.WriteLine("4. Вийти");

                string choice = Console.ReadLine();

                switch (choice)
