using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace PhonebookManagenment
{
    class PhoneBook : IPhoneBook
    {
        public SortedList<string, string> phoneBook = new SortedList<string, string>();
        public void ShowPhoneBook()
        {
            Console.WriteLine($"name\t\t\tPhone number");
            foreach (KeyValuePair<string, string> name in phoneBook)
            {
                Console.WriteLine($"{name.Key}\t\t\t{name.Value}");
            }
            
        }
        public void InsertPhone(string name, string phoneNumber)
        {
             string temp = "";
             if (phoneBook.ContainsKey(name))
             {                
                  temp = phoneBook[name];
                  phoneBook.Remove(name);
                  phoneBook.Add(name, (temp + ":" + phoneNumber));                
             }
             else
             {
                  phoneBook.Add(name, phoneNumber);
             }                       
        }
        public void RemovePhone(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                phoneBook.Remove(name);
            }    
        }
        public void UpdatePhone(string name, string newPhoneNumber)
        {
            string temp = "";
            if (phoneBook.ContainsKey(name))
            {
                temp = phoneBook[name];
                phoneBook.Remove(name);
                phoneBook.Add(name, newPhoneNumber);
            }
        }
        public void SeachPhone(string name)
        {
            Console.WriteLine($"name\t\t\tPhone number");
            foreach (string names in phoneBook.Keys)
            {
                if (names.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"{names}\t\t\t{phoneBook[names]}");
                }
            }
        }
        public void Sort()
        {
           
        }
    }
}
