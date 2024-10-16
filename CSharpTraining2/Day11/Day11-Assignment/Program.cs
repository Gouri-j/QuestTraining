using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day11_Assignment
{
    internal class Program
    {
        static List<CreditCard> cc = new List<CreditCard>();
        static void AddCard()
        {
            Console.WriteLine("Enter Name of user:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter Card Number: ");
            int cardNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter expiry month: ");
            string expMonth = Console.ReadLine();

            Console.WriteLine("Enter expiry year: ");
            string expYear = Console.ReadLine();

            var addCard = new CreditCard()
            {
                Name = userName,
                CardNumber = cardNo,
                ExpiryMonth = expMonth,
                ExpiryYear = expYear
            };

            cc.Add(addCard);

            Console.WriteLine("Card added successfully");
        }
        static void SearchByNumber()
        {
            Console.WriteLine("Enter the Card number:");
            int number = int.Parse(Console.ReadLine());

            foreach (var card in cc)
            {
                if(card.CardNumber == number)
                {
                    Console.WriteLine($"User name:{card.Name}");
                    Console.WriteLine($"Expiry date: {card.ExpiryMonth}/{card.ExpiryYear}");
                }
                else
                {
                    Console.WriteLine("Card not Found");
                }
            }
        }
        static void UpdateByNumber()
        {
            Console.WriteLine("Enter the Card number:");
            int num = int.Parse(Console.ReadLine());

            foreach (var card in cc)
            {
                if (card.CardNumber == num)
                {
                    Console.WriteLine("Enter User name:");
                    var name = Console.ReadLine();
                    card.Name = name;

                    Console.WriteLine("Enter Expiry month:");
                    var month = Console.ReadLine();
                    card.ExpiryMonth = month;

                    Console.WriteLine("Enter Expiry year:");
                    var year = Console.ReadLine();
                    card.ExpiryYear = year;
                }
                else
                {
                    Console.WriteLine("Invalid card number");
                }
            }
        }
        static void Delete()
        {
            Console.WriteLine("Enter the Card number:");
            int cNum = int.Parse(Console.ReadLine());

            foreach (var card in cc)
            {
                if (card.CardNumber == cNum)
                {
                    cc.Remove(card);
                    Console.WriteLine("Card deleted successfully");
                }
                else
                {
                    Console.WriteLine("Card number is invalid");
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter option:");
                Console.WriteLine("1. Add Card");
                Console.WriteLine("2. Search card by number");
                Console.WriteLine("3. Update card");
                Console.WriteLine("4. Delete card");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddCard();
                        break;
                    case "2":
                        SearchByNumber();
                        break;
                    case "3":
                        UpdateByNumber();
                        break;
                    case "4":
                        Delete();
                        break;
                    case "5":
                        break;
                }

            }
        }
    }
}
