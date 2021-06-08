using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;

namespace PhonebookManagenment
{
    class Program
    {
        const int min = 1;
        const int max = 6;
        const int   Insert = 1,
                    Remove = 2,
                    Update = 3,
                    Search = 4,
                    Sort = 5,
                    Exit = 6;
        public static PhoneBook phoneBook = new PhoneBook();

        static void Main(string[] args)
        {
            Process();
        }
        public static void BuilMenu(out int option)
        {
            do
            {
                Console.WriteLine("----Calculator Menu----");
                Console.WriteLine("1. Insert Phone number");
                Console.WriteLine("2. remove Phone number");
                Console.WriteLine("3. Update phone number");
                Console.WriteLine("4. Search phone number");
                Console.WriteLine("5. sort");
                Console.WriteLine("6. Exit");
                Console.Write($"Please choice a number ({min},{max}):");
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    option = 0;
                }
            }
            while (option < min || option > max);
        }
        public static void Process()
        {
            var selected = 0;
            do
            {
                BuilMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case Insert:
                        {
                            InsertPhoneNumber();
                            break;
                        }
                    case Remove:
                        {
                            RemovePhoneNumber();                         
                            break;
                        }
                    case Update:
                        {
                            UpdatePhoneNumber();
                            break;
                        }
                    case Search:
                        {
                            SearchPhoneNumber();
                            break;
                        }
                    case Sort:
                        {
                            SortPhoneBook();
                            break;
                        }
                    case Exit:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != max);
        }
        public static bool IsNumber(string str)
        {
            
            foreach (Char key in str)
            {
                if (!Char.IsNumber(key) || str.Substring(0,1) != "0" )
                {
                    return false;
                }
            }
            return true;
        }
        
        public static void InsertPhoneNumber()
        {
            Console.Write("Enter name:");
            string name = Console.ReadLine();                      
            Console.Write("Enter number:");
            string number = Console.ReadLine();
            bool check = IsNumber(number);
            while (number.Length < 10 || number.Length >10 || check == false)
            {
                Console.WriteLine("Phone number is invalid!!");
                Console.Write("Please reinput phone number: ");
                number = Console.ReadLine();
                check = IsNumber(number);
            }
            phoneBook.InsertPhone(name, number);
            //phoneBook.ShowPhoneBook();
        }
        public static void RemovePhoneNumber()
        {
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            phoneBook.RemovePhone(name);
            //phoneBook.ShowPhoneBook();

        }
        public static void UpdatePhoneNumber()
        {
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            Console.Write("Enter new number:");
            string number = Console.ReadLine();
            bool check = IsNumber(number);
            while (number.Length < 10 || number.Length > 10 || check == false)
            {
                Console.WriteLine("Phone number is invalid!!");
                Console.Write("Please reinput phone number: ");
                number = Console.ReadLine();
                check = IsNumber(number);
            }
            phoneBook.UpdatePhone(name,number);
            //phoneBook.ShowPhoneBook();
        }
        public static void SearchPhoneNumber()
        {
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            phoneBook.SeachPhone(name);
        }
        public static void SortPhoneBook()
        {
            phoneBook.Sort();
        }

    }
}
