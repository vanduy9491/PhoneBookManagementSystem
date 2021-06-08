using System;
using System.Collections.Generic;
using System.Text;

namespace PhonebookManagenment
{
    interface IPhoneBook
    {
       
        void InsertPhone(string name, string phoneNumber);
        void RemovePhone(string name);
        void UpdatePhone(string name, string newPhoneNumber);
        void SeachPhone(string name);
        void Sort();
    }
}
