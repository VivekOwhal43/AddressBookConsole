using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<string> addressBookName = new List<string>(); // Creating a list to maintain address book name
        List<string> cityName = new List<string>();         // Creating a list to maintain address book name
        List<string> stateName = new List<string>();        // Creating a list to maintain address book name
        Dictionary<string, List<AddContact>> dict = new Dictionary<string, List<AddContact>>(); // Creating dictionary to Maintain all the address book 
        public void CreateAddressBook(string n)             // class method to create new address book and store it in dictionary
        {
            addressBookName.Add(n.ToLower());                         // Add address book name which is provided by user  in address book list

            if (dict.Count == 0)                            // Checking that dictionary is empty or not
            {
                dict.Add(n.ToLower(), new List<AddContact>());        // creating key value pair where address book name is key and all the redord of address book as value
            }
            else
            {
                if (dict.ContainsKey(n.ToLower()))                    // Checking that address book given by user is already present in dictionary or not
                {
                    Console.WriteLine("This AddressBook is also present");
                }
                else
                {
                    dict.Add(n.ToLower(), new List<AddContact>());    // creating key value pair where address book name is key and all the redord of address book as value
                }

            }
        }
        public void cityNames(string city)
        {
            if (cityName.Count == 0)
            {
                cityName.Add(city.ToLower());
            }
            else
            {
                if (cityName.Contains(city))
                {
                    return;
                }
                else
                {
                    cityName.Add(city.ToLower());
                }
            }
        }
        public void stateNames(string state)
        {
            if (stateName.Count == 0)
            {
                stateName.Add(state.ToLower());
            }
            else
            {
                if (stateName.Contains(state.ToLower()))
                {
                    return;
                }
                else
                {
                    stateName.Add(state.ToLower());
                }
            }
        }
        public int temp = 0;
        public void DiplayListOfAddressBook()               // Class method to display name Address book
        {
            if (addressBookName.Count == 0)                 // Checking that address book list is empty or not
            {
                Console.WriteLine("\nThere is no address book avilable");
                temp = 1;
            }
            else
            {
                foreach (string list in addressBookName)        // Accessing all the names in address book
                {
                    Console.WriteLine("\n\nList of existing Address Book Are : ");
                    Console.WriteLine(list);
                    Console.WriteLine();
                }
            }
        }
        public void DisplayDictionary()                         // Class method to display all the records of all address book
        {
            foreach (var content in dict.Keys)                  // Accessing all the address book name of dictionary
            {
                Console.WriteLine("\n\nAddress Book : " + content);
                int i = 1;
                foreach (var value in dict[content].ToList())   // Accessing all the address book records  by dictionary key
                {
                    Console.WriteLine("\nRecord - " + i);
                    Console.WriteLine("First Name : " + value.firstName);
                    Console.WriteLine("Last Name : " + value.lastName);
                    Console.WriteLine("Email : " + value.email);
                    Console.WriteLine("City : " + value.city);
                    Console.WriteLine("State : " + value.state);
                    Console.WriteLine("Zip code : " + value.postalCode);
                    Console.WriteLine("Phone Number : " + value.contactNumber);
                    i++;
                }
            }
        }
        public void AddRecords(string name)                     // Creating class method to add Person Record in List
        {
            AddContact input = new AddContact();                // Creating a object of PersonInput Class
            // Getting all the details from user and store it in PersonInput Class variales through object                                              
            Console.WriteLine("\nEnter your First Name : ");
            input.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Email : ");
            input.email = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Postal Code : ");
            input.postalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.contactNumber = Convert.ToInt64(Console.ReadLine());
            foreach (var content in dict.Keys)                  // Accessing all the address book name of dictionary
            {
                if (content == name)                            // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    if (dict[content].Count == 0)
                    {
                        dict[name].Add(input);
                        cityNames(input.city);
                        stateNames(input.state);               // Adding person record in Address book 
                        Console.WriteLine("\nRecord Added successfully in Address Book");
                    }
                    else
                    {
                        foreach (var value in dict[content].ToList())       // Accessing all the record of address book by dictionary key
                        {
                            //if (value.contactNumber != input.contactNumber)           // Checking that phone number provided by user is matching with Existing Reord or not
                            if (value != input)
                            {
                                dict[name].Add(input);                                  // Adding person record in Address book
                                cityNames(input.city);
                                stateNames(input.state);
                                Console.WriteLine("\nRecord Added successfully in Address Book");
                            }
                            else
                            {
                                Console.WriteLine($"\nThis Record is already present in {content} Address Book");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\n{content} Address Book not found");
                }

            }

        }
        public void findDuplicateRecord()
        {
            foreach (var record in dict)
            {

            }
        }
        string fn, ln;
        public void UpdateRecords(string ab)                            // Creating class method to update record which takes first name and last name as parameter
        {
            foreach (var content in dict.Keys)                          // Accessing all the record of address book by dictionary key
            {
                if (content == ab)                                      // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine();                            // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine();                            // Store the user lastname in variable
                    foreach (var value in dict[content].ToList())
                    {
                        if (value.firstName == fn && value.lastName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                        {
                            Console.WriteLine("\n\nWhich field you want to update : ");
                            Console.WriteLine("\n1:First Name\n2.Last Name\n3. Email Address\n4.City\n5.State\n6.Email\n7.Zip Code\n8.PhoneNumber\n9.Exit");
                            Console.WriteLine("\nEnter your Choice : ");
                            int ch = Convert.ToInt32(Console.ReadLine()); // Store the user choice which want to update 
                            switch (ch)
                            {
                                case 1:
                                    Console.WriteLine("\nEnter new first name : ");
                                    string f = Console.ReadLine();
                                    value.firstName = f;                    // Update the first name of record in address book
                                    Console.WriteLine("\nFirst Name Updated Successfully");
                                    break;
                                case 2:
                                    Console.WriteLine("\nEnter new last name : ");
                                    string l = Console.ReadLine();
                                    value.lastName = l;                         // Update the last name of record in address book
                                    Console.WriteLine("\nLast Name Updated Successfully");
                                    break;
                                case 3:
                                    Console.WriteLine("\nEnter new address : ");
                                    string a = Console.ReadLine();
                                    value.email = a;                                // Update the email address of record in address book
                                    Console.WriteLine("\nAddress Updated Successfully");
                                    break;
                                case 4:
                                    Console.WriteLine("\nEnter new city name : ");
                                    string c = Console.ReadLine();
                                    value.city = c;                                 // Update the city name of record in address book
                                    Console.WriteLine("\nCity Name Updated Successfully");
                                    break;
                                case 5:
                                    Console.WriteLine("\nEnter new state : ");
                                    string s = Console.ReadLine();
                                    value.state = s;                                // Update the state name of record in address book
                                    Console.WriteLine("\nState Name Updated Successfully");
                                    break;
                                case 6:
                                    Console.WriteLine("\nEnter new Postal Code : ");
                                    int z = Convert.ToInt32(Console.ReadLine());
                                    value.postalCode = z;                               // Update the zipcode of record in address book
                                    Console.WriteLine("\nPostal Code Updated Successfully");
                                    break;
                                case 7:
                                    Console.WriteLine("\nEnter new Phone Number : ");
                                    int p = Convert.ToInt32(Console.ReadLine());
                                    value.contactNumber = p;                            // Update the phone number of record in address book
                                    Console.WriteLine("\nPhone Number Updated Successfully");
                                    break;
                                default:
                                    Console.WriteLine("\nEnter valid choice");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
        public void DeleteRecord(string ab)  // Creating class method to delete record which takes first name as parameter
        {
            foreach (var content in dict.Keys) // Accessing address book name by dictionary key
            {
                if (content == ab)  // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine(); // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine();
                    foreach (var value in dict[content].ToList())  // Accessing all the record of address book by dictionary key
                    {
                        if (value.firstName == fn && value.lastName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                        {
                            Console.WriteLine("\nEnter your first name which you want to delete : ");
                            string f = Console.ReadLine(); // Store the user firstname in variable
                            dict[content].Remove(value); // Deleting all the details of one user in Address Book
                            Console.WriteLine("\nRecord Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }

        public void DisplayPersonsByCityName(string cName) // Class method to display all the records of all address book
        {
            foreach (var city in cityName)
            {
                if (cName.Equals(city))
                {
                    Console.WriteLine($"\nAll records present in multiple address books where city name \"{city}\" are : ");
                    foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                    {
                        Console.WriteLine("\n\nAddress Book : " + content);
                        int i = 1;
                        foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                        {
                            if (value.city == city)
                            {
                                Console.WriteLine("\nRecord - " + i);
                                Console.WriteLine("First Name : " + value.firstName);
                                Console.WriteLine("Last Name : " + value.lastName);
                                Console.WriteLine("City : " + value.city);
                                Console.WriteLine("State : " + value.state);
                                Console.WriteLine("Email : " + value.email);
                                Console.WriteLine("Zip code : " + value.postalCode);
                                Console.WriteLine("Phone Number : " + value.contactNumber);
                                i++;
                            }
                        }
                    }
                }
            }
        }
        public void DisplayPersonsByStateName(string sName) // Class method to display all the records of all address book
        {
            foreach (var state in stateName)
            {
                if (sName.Equals(state))
                {
                    Console.WriteLine($"\nAll records present in multiple address books where state name \"{state}\" are : ");
                    foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                    {
                        Console.WriteLine("\n\nAddress Book : " + content);
                        int i = 1;
                        foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                        {
                            if (value.state == state)
                            {
                                Console.WriteLine("\nRecord - " + i);
                                Console.WriteLine("First Name : " + value.firstName);
                                Console.WriteLine("Last Name : " + value.lastName);
                                Console.WriteLine("City : " + value.city);
                                Console.WriteLine("State : " + value.state);
                                Console.WriteLine("Email : " + value.email);
                                Console.WriteLine("Zip code : " + value.postalCode);
                                Console.WriteLine("Phone Number : " + value.contactNumber);
                                i++;
                            }
                        }
                    }
                }
            }
        }
    }
}