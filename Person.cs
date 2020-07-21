using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_Application
{
    class Person
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
        public string getFirstName() 
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public string getAddress() 
        {
            return this.address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getState()
        {
            return this.state;
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
            return this.zip;
        }
        public void setZip(string zip)
        {
            this.zip = zip;
        }
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
