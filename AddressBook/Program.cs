using System;
using System.Collections.Specialized;
using NLog;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddContact[] addContact =new AddContact[4];
            int number=0;
            AddressBookMain addressBookMain = new AddressBookMain();
            Console.Write("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                addressBookMain.addContactDetails();
            }
            //addressBookMain.getContactDetails();
            addressBookMain.showContactDetails();
        }
    }
}