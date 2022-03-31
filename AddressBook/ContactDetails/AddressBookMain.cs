namespace AddressBook
{
    public class AddressBookMain
    {
        //NLog Iementation
        // private readonly NLogDemo nLogDemo = new NLogDemo();
        public List<AddContact> contactList = new List<AddContact>();
        

        public void addContactDetails()
        {
            AddContact addContact = new AddContact();
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
        }
    }
}