using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        
        public String PassportNumber { get; set; }

        public string EmailAddress { get; set;}
        [MinLength(3,ErrorMessage ="Longeur mainimale 3 caractères")]
        [MaxLength(25, ErrorMessage = "Longeur maximale 25 caractères")]

        public string FirstName { get; set;}
        
        public string LastName { get; set;}

        public string TelNumber { get; set;}
        public ICollection<Flight> Flights { get; set; }
        public Passenger() { }
        public Passenger(DateTime birthDate, String passportNumber, string emailAddress, string firstName, string lastName, string telNumber, ICollection<Flight> flights)
        {
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
            Flights = flights;
        }
        public Passenger(DateTime birthDate, String passportNumber, string emailAddress, string firstName, string lastName, string telNumber)
        {
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
            
        }


        public bool checkProfile (string firstName,string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }
        public bool checkProfile(string firstName, string lastName,string mail)
        {
            return FirstName == firstName && LastName == lastName && mail == EmailAddress;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }

    }
}
