using System;
using System.Collections.Specialized;
using System.Numerics;
using NLog;

namespace AddressBook
{
    internal class Program
    {
        public static int quit = 0;
        static void Main(string[] args)
        {
            //AddContact[] addContact =new AddContact[4];
            int choiceNumber = 0, recordEntryNumber = 0;
            AddressBookMain addressBookMain = new AddressBookMain();
            // 
            // 
            // //addressBookMain.getContactDetails();
            // addressBookMain.showContactDetails();
            do              //this loop is for continuously adding data and removing data and updating record.
            //until the choice is 2 for exit.
            {
                Console.Write("\nSelect Option from below Menu");
                Console.WriteLine("\n 1. Add Contact \n 2. Show Contact List \n 3. Search Via Name and Edit Contact \n 4. Search Via Name and Delete Contact \n 5. Add New Address Book");
                Console.Write("\nEnter Choice: ");
                choiceNumber = Convert.ToInt32(Console.ReadLine());
                switch (choiceNumber)           // switch case for getting user choice from menu.
                {
                    case 1:
                        Console.WriteLine("How many contacts do you want to add ?");
                        recordEntryNumber = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < recordEntryNumber; i++)
                        {
                            addressBookMain.addContactDetails();
                        }
                    break;

                    case 2:
                        addressBookMain.showContactDetails();
                    break;

                    case 3:
                        addressBookMain.editContact();
                    break;

                    case 4:
                        addressBookMain.deleteContact();
                    break;

                    case 5:
                        
                    break;

                    default:
                        Console.Write($"Enter A Value in specified Range");
                    break;
                }
                Console.Write("\nDo you want to continue in Address Book Main Menu ? \n Press 1 to Continue \n Press 2 to Exit\n");
                Console.Write("\nEnter Choice: ");
                quit = Convert.ToInt32(Console.ReadLine());
            } while (quit != 2);
        }
    }
}