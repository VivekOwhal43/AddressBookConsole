using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.getContactDetails();
            addressBookMain.showContactDetails();
        }
    }
}