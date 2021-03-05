using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment2
{
    class Customer
    {
        private DateTime _dateOfBirth;
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (!value.Equals(""))
                {
                    _name = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                if (value < DateTime.Now)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new Exception("Invalid Birth date");
                    
                }
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - DateOfBirth.Year;
                if (DateOfBirth > DateTime.Now.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }

        public bool Discount => Age >= 60;

        public Customer(string name, DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
            this.Name = name;
        }
    }
}