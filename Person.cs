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
<<<<<<< HEAD
        string phoneNo;
        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNo)
=======
        string phoneNumber;
        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber)
>>>>>>> 264c3219a9dea84285c72b8b8b03fc8a6283a0d2
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
<<<<<<< HEAD
        public void SetAddress(string address)
=======
        public void setAddress(string address)
>>>>>>> 264c3219a9dea84285c72b8b8b03fc8a6283a0d2
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
<<<<<<< HEAD
        public string getPhoneNo()
=======
        public string getPhoneNumber()
>>>>>>> 264c3219a9dea84285c72b8b8b03fc8a6283a0d2
        {
            return this.phoneNumber;
        }
<<<<<<< HEAD
        public void setPhoneNo(string phoneNo)
=======
        public void setPhoneNumber(string phoneNumber)
>>>>>>> 264c3219a9dea84285c72b8b8b03fc8a6283a0d2
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
