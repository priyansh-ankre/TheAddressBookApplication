using System;
using System.Collections.Generic;

namespace Address_Book_Application
{
    class AddressBookMain
    {
        List<Person> personsList = new List<Person>();
        Dictionary<string, Person>cityMap;
        Dictionary<string, Person> stateMap;
        
        public AddressBookMain()
        {
            cityMap = new Dictionary<string, Person>();
            stateMap = new Dictionary<string, Person>();
        }

        public void addPerson()
        {
            Console.WriteLine("enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName);

            Console.WriteLine("enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine(lastName);

            Console.WriteLine("enter address");
            string address = Console.ReadLine();
            Console.WriteLine(address);

            Console.WriteLine("enter city");
            string city = Console.ReadLine();
            Console.WriteLine(city);

            Console.WriteLine("enter state");
            string state = Console.ReadLine();
            Console.WriteLine(state);

            Console.WriteLine("enter zip");
            string zip = Console.ReadLine();
            Console.WriteLine(zip);

            Console.WriteLine("enter phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine(phoneNumber);

            Person person1 = new Person(firstName, lastName, address, city, state, zip, phoneNumber);
            Person duplicate = getObjectWithName(firstName);
            if (person1.Equals(duplicate))
            {
                Console.WriteLine("there already exists person  with same name in address book");
                return;
            }
            personsList.Add(person1);
            cityMap.Add(city,person1);
            stateMap.Add(state, person1);
        }
        public Person getObjectWithName(string firstName)
        {
            foreach (Person person in personsList)
            {
                if (person.getFirstName().Equals(firstName))
                {
                    return person;
                }
            }
            return new Person("", "", "", "", "", "", "");
        }
        public void editperson()
        {
            Person personToEdit = new Person("", "", "", "", "", "", "");
            Console.WriteLine("enter first name of person to edit");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName);

            foreach (Person person in personsList)
            {
                if (person.getFirstName().Equals(firstName))
                {
                    personToEdit = person;
                }
            }
            int quit = 0;
            do
            {
                Console.WriteLine("enter 1 for editing address");
                Console.WriteLine("enter 2 for editing city");
                Console.WriteLine("enter 3 for editing state");
                Console.WriteLine("enter 4 for editing zip");
                Console.WriteLine("enter 5 for editing phone number");
                Console.WriteLine("enter 6 to quit");
                int choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter new address");
                        string address = Console.ReadLine();
                        Console.WriteLine(address);

                        personToEdit.setAddress(address);
                        break;
                    case 2:
                        Console.WriteLine("enter new city");
                        string city = Console.ReadLine();
                        Console.WriteLine(city);

                        personToEdit.setCity(city);
                        break;
                    case 3:
                        Console.WriteLine("enter new state");
                        string state = Console.ReadLine();
                        Console.WriteLine(state);

                        personToEdit.setState(state);
                        break;
                    case 4:
                        Console.WriteLine("enter new zip");
                        string zip = Console.ReadLine();
                        Console.WriteLine(zip);

                        personToEdit.setZip(zip);
                        break;
                    case 5:
                        Console.WriteLine("enter new phone number");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine(phoneNumber);

                        personToEdit.setPhoneNumber(phoneNumber);
                        break;
                    case 6:
                        quit = 1;
                        break;
                }

            } while (quit==0);

        }
        public void displayAddressBook()
        {
            foreach (Person person in personsList)
            {
                Console.WriteLine(person);
            }
        }
        public void deletePerson()
        {
            Console.WriteLine("enter first name of person ");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName);

            Person personToDelete = getObjectWithName(firstName);
            personsList.Remove(personToDelete);
        }
        public void sortByName()
        {
            personsList.Sort();
            foreach (var srt in personsList)
            {
                Console.WriteLine(srt.getFirstName());
            }
        }
        public void sortByCity()
        {
            personsList.Sort(delegate (Person x, Person y)
            {
                return x.getCity().CompareTo(y.getCity());
            });
        }
        public void sortByState()
        {
            personsList.Sort(delegate (Person x, Person y)
            {
                return x.getState().CompareTo(y.getState());
            });
        }
        public void sortByZip()
        {
            personsList.Sort(delegate (Person x, Person y)
            {
                return x.getzip().CompareTo(y.getzip());
            });
        }
        public void viewByCity()
        {
            Console.WriteLine("enter city");
            string city = Console.ReadLine();
            Console.WriteLine(city);
            Console.WriteLine(cityMap.GetValueOrDefault(city));
        }
        public void viewByState()
        {
            Console.WriteLine("enter state");
            string state = Console.ReadLine();
            Console.WriteLine(state);
            Console.WriteLine(cityMap.GetValueOrDefault(state));
        }

        public static void Main(string[] args)
        {
            int quit = 0;
            AddressBookMain addressBook = new AddressBookMain();
            do
            {
                Console.WriteLine("enter 1 for adding person to address book");
                Console.WriteLine("enter 2 for editing person");
                Console.WriteLine("enter 3 for deleting person");
                Console.WriteLine("enter 4 to display address book");
                Console.WriteLine("enter 5 to sort address book by name");
                Console.WriteLine("enter 6 to sort address book by city");
                Console.WriteLine("enter 7 to sort address book by state");
                Console.WriteLine("enter 8 to sort address book by zip");
                Console.WriteLine("enter 9 to view person by city");
                Console.WriteLine("enter 9 to view person by state");
                Console.WriteLine("enter 11 to quit");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(option);
                
                switch (option)
                {
                    case 1:
                        addressBook.addPerson();
                        break;
                    case 2:
                        addressBook.displayAddressBook();
                        addressBook.editperson();
                        break;
                    case 3:
                        addressBook.displayAddressBook();
                        addressBook.deletePerson();
                        break;
                    case 4:
                        addressBook.displayAddressBook();
                        break;
                    case 5:
                        addressBook.sortByName();
                        break;
                    case 6:
                        addressBook.sortByCity();
                        break;
                    case 7:
                        addressBook.sortByState();
                        break;
                    case 8:
                        addressBook.sortByZip();
                        break;
                    case 9:
                        addressBook.viewByCity();
                        break;
                    case 10:
                        addressBook.viewByState();
                        break;
                    case 11:
                        quit = 1;
                        break;
                }
            } while (quit==0);
            addressBook.displayAddressBook();

        }
    }
}
