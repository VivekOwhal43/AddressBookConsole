namespace AddressBook
{
    public class AddressBookMain
    {
        string firstName = "", lastName = "", email = "", city = "", state = "";
        double contactNumber;
        int postalCode;

        public AddressBookMain(string firstName, string lastName, string email, string city, string state, double contactNumber, int postalCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.city = city;
            this.state = state;
            this.contactNumber = contactNumber;
            this.postalCode = postalCode;
        }

        public void showContactDetails()
        {
            Console.WriteLine("============ Contact Details =========");
            Console.WriteLine("First Name  : " + firstName);
            Console.WriteLine("Last Name   : " + lastName);
            Console.WriteLine("City Name:  : " + city);
            Console.WriteLine("State  Name : " + state);
            Console.WriteLine("Contact Num : " + contactNumber);
            Console.WriteLine("Enter Email : " + email);
            Console.WriteLine("Postal Code : " + postalCode);

        }
    }
}