using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addressBookMain = new AddressBookMain("Vivek", "Owhal", "vivek@gmail.com", "Mumbai","Maharashtra", 8660154789, 412854);
            addressBookMain.showContactDetails();
        }
    }
}