using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AddressBook
{
    public class AddressBookMain
    {
        //NLog Iementation
        // private readonly NLogDemo nLogDemo = new NLogDemo();
        public List<AddContact> contactList = new List<AddContact>();
        int continueloop;
        int ch;
        public void addContactDetails()
        {
            AddContact addContact = new AddContact();
            Console.WriteLine("============ Enter Contact Details =========");
            Console.WriteLine("Enter First Name:");
            addContact.firstName = Console.ReadLine();
            //nLogDemo.LogDebug("SuccessS done okay");
            Console.WriteLine("Enter Last Name:");
            addContact.lastName = Console.ReadLine();
            Console.WriteLine("Enter City Name:");
            addContact.city = Console.ReadLine();
            Console.WriteLine("Enter State Name:");
            addContact.state = Console.ReadLine();
            Console.WriteLine("Enter Contact Number:");
            addContact.contactNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email :");
            addContact.email = Console.ReadLine();
            Console.WriteLine("Postal Code :");
            addContact.postalCode = Convert.ToInt32(Console.ReadLine());
            contactList.Add(addContact);            // Add Details to contacts
        }

        public void showContactDetails()
        {
            int contactCount = 1; // displaying contact number in address book
            foreach (var details in contactList)
            {
                Console.WriteLine($"============ Contact {contactCount} Details =========");
                Console.WriteLine("First Name  : " + details.firstName);
                Console.WriteLine("Last Name   : " + details.lastName);
                Console.WriteLine("City Name:  : " + details.city);
                Console.WriteLine("State  Name : " + details.state);
                Console.WriteLine("Contact Num : " + details.contactNumber);
                Console.WriteLine("Enter Email : " + details.email);
                Console.WriteLine("Postal Code : " + details.postalCode);
                contactCount++;
            }
            if (contactList.Count == 0)
            {
                Console.WriteLine(" No contacts has been added in list \n Please add contacts and try again");
            }
            else
            {
                Console.Write($"\nContact Not Found");
            }
        }

        public void editContact()
        {
            do
            {
                Console.Write("Enter Name : ");
                string searchName = Console.ReadLine();
                foreach (var contact in contactList)
                {
                    if (searchName == contact.firstName)
                    {
                        // contactList.Remove(contact);
                        // Console.Write($"Enter Modification Details: ");
                        // addContactDetails();
                        Console.Write($"Which Field You Want to Update?");
                        Console.WriteLine($"\n1. First Name \n2. Last Name \n3. City Name \n4. State Name \n5. Contact Number \n6. Email \n7. Postal Code");
                        int updateChoice = Convert.ToInt32(Console.ReadLine());
                        switch (updateChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter First Name:");
                                string fname = Console.ReadLine();
                                contact.firstName = fname;
                                break;

                            case 2:
                                Console.WriteLine("Enter Last Name:");
                                string lname = Console.ReadLine();
                                contact.lastName = lname;
                                break;

                            case 3:
                                Console.WriteLine("Enter City Name:");
                                string ctname = Console.ReadLine();
                                contact.city = ctname;
                                break;

                            case 4:
                                Console.WriteLine("Enter State Name:");
                                string stname = Console.ReadLine();
                                contact.state = stname;
                                break;

                            case 5:
                                Console.WriteLine("Enter Contact Number:");
                                double contNum = Convert.ToInt64(Console.ReadLine());
                                contact.contactNumber = contNum;
                                break;

                            case 6:
                                Console.WriteLine("Enter First Name:");
                                string eml = Console.ReadLine();
                                contact.email = eml;
                                break;

                            case 7:
                                Console.WriteLine("Enter Postal Code:");
                                int pCode = Convert.ToInt32(Console.ReadLine());
                                contact.contactNumber = pCode;
                                break;

                            default:
                                Console.WriteLine("Please enter value within specified range");
                                break;
                        }
                    }
                    else if (contactList.Count.Equals(0))
                    {
                        Console.WriteLine("No contacts has been added in list \n Please add contacts and try again");
                    }
                    else
                    {
                        Console.Write($"\nContact Not Found");
                    }
                }
                Console.WriteLine("Do you want to continue Editing Addressbook? \n Enter 1 For 'YES' and 2 For 'NO' ");
                ch = Convert.ToInt32(Console.ReadLine());
            } while (ch != 2);
            Console.WriteLine(" Exit from Edit Menu");
        }

        public void deleteContact()
        {
            do
            {
                Console.WriteLine(" \n Delete Contact Using Name");
                Console.Write("Enter Name : ");
                string searchName = Console.ReadLine();
                foreach (var contact in contactList)
                {
                    if (searchName == contact.firstName)
                    {
                        contactList.Remove(contact);
                        Console.Write($" Coontact Deleted Successfully \n");
                        // addContactDetails();
                    }
                    else if (searchName != contact.firstName)
                    {
                        Console.WriteLine("No contacts has been added in list \n Please add contacts and try again");
                    }
                    else
                    {
                        Console.Write($"\nContact Not Found");
                    }
                }
                //Console.WriteLine("1.Edit Contact Using Name");
                Console.WriteLine("Do you want to continue deleting contacts in Addressbook? \n Enter 1 For 'YES' and 2 For 'NO' ");
                ch = Convert.ToInt32(Console.ReadLine());
            } while (ch != 2);
            Console.WriteLine("Exit from Delete Menu");
        }
    }
}