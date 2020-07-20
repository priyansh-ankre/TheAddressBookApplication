using System;
using System.Collections;


namespace Address_Book_Application
{
    class AddressBookMain
    {
        ArrayList records = new ArrayList();
        public void addPerson()
        {
            string firstName = "", lastName = "", address = "", city = "", state = "", phoneNo = "",zip="";

            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
            Console.WriteLine(firstName);

            Console.WriteLine("Enter last name:");
            lastName = Console.ReadLine();
            Console.WriteLine(lastName);

            Console.WriteLine("Enter address:");
            address = Console.ReadLine();
            Console.WriteLine(address);

            Console.WriteLine("Enter city:");
            city = Console.ReadLine();
            Console.WriteLine(city);

            Console.WriteLine("Enter state:");
            state = Console.ReadLine();
            Console.WriteLine(state);

            Console.WriteLine("Enter zip:");
            zip = Console.ReadLine();
            Console.WriteLine(zip);

            Console.WriteLine("Enter phone no:");
            phoneNo = Console.ReadLine();
            Console.WriteLine(phoneNo);

            Person p = new Person(firstName, lastName, address, city, state, zip, phoneNo);
            records.Add(p);
            Console.WriteLine("Added Successfully");

        }
        static void Main(string[] args)
        {
        
        }
    }
}
