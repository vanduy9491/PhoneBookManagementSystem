using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace PhonebookManagenment
{
    class PhoneBook : IPhoneBook
    {
        //public SortedList<string, string> phoneBook = new SortedList<string, string>();
        public MyGeneric<string,string> phonebook = new MyGeneric<string,string>();
        //public void ShowPhoneBook()
        //{
           
        //    Console.WriteLine($"name\t\t\tPhone number");
        //    foreach (KeyValuePair<string, string> name in phoneBook)
        //    {
        //        Console.WriteLine($"{name.Key}\t\t\t{name.Value}");
        //    }
            
        //}
        public void InsertPhone(string name, string phoneNumber)
        {
            string temp = "";
            //if (phoneBook.ContainsKey(name))
            //{
            //    temp = phoneBook[name];
            //    phoneBook.Remove(name);
            //    phoneBook.Add(name, (temp + ":" + phoneNumber));
            //}
            //else
            //{
            //    phoneBook.Add(name, phoneNumber);
            //}
            if (phonebook.ContainsKey(name) != null)
            {
                
                phonebook.Add(name, (phonebook.ContainsKey(name) + ":" + phoneNumber));
                phonebook.Remove(name);
            }
            else
            {
                phonebook.Add(name, phoneNumber);
            }
            
            phonebook.ShowPhoneBooks();
        }
        public void RemovePhone(string name)
        {
            //if (phoneBook.ContainsKey(name))
            //{
            //    phoneBook.Remove(name);
            //}
            if (phonebook.ContainsKey(name) != null)
            {

                phonebook.Remove(name);
            }
            phonebook.ShowPhoneBooks();
        }
        public void UpdatePhone(string name, string newPhoneNumber)
        {
            //string temp = "";
            //if (phoneBook.ContainsKey(name))
            //{
            //    temp = phoneBook[name];
            //    phoneBook.Remove(name);
            //    phoneBook.Add(name, newPhoneNumber);
            //}
            if (phonebook.ContainsKey(name) != null)
            {
                phonebook.Remove(name);
                phonebook.Add(name, newPhoneNumber);
                
            }
            else
            {
                phonebook.Add(name, newPhoneNumber);
            }
            phonebook.ShowPhoneBooks();
        }
        public void SeachPhone(string name)
        {
            Console.WriteLine($"name\t\t\tPhone number");
            //foreach (string names in phoneBook.Keys)
            //{
            //    if (names.ToLower().Contains(name.ToLower()))
            //    {
            //        Console.WriteLine($"{names}\t\t\t{phoneBook[names]}");
            //    }
            //}
            phonebook.Find(name);
        }
        public void Sort()
        {
            phonebook.Sortt();
            phonebook.ShowPhoneBooks();
        }
    }
}
