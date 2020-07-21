using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Address_Book_Application
{
    public class Person : IComparable<Person>
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zip;
        string phoneNumber;
        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.address = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
        }
        public int CompareTo(Person person)
        {
            return this.firstName.CompareTo(person.firstName);
        }
     
        public string getFirstName() 
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getAddress() 
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getState()
        {
            return state;
        }
        public void setState(string state)
        {
            this.state = state;
        }
        public string getCity()
        {
            return this.city;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getzip()
        {
            return zip;
        }
        public void setZip(string zip)
        {
            this.zip = zip;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public string toString()
        {
            return firstName + ", " + lastName + ", " + address + ", " + city + ", " + state + ", " + zip + ", " + phoneNumber;
        }
    }
}
