using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2
{
    internal class User
    {
        private string name = "";
        private string surname = "";
        private string patronymic = "";
        private DateTime birthDate;

        internal User(string name, string surname, string patronymic, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDate = birthDate;
        }
        
        internal string Name { get { return name; } set { name = value; } }

        internal string Surname { get { return surname; } set { surname = value; } }

        internal string Patronymic { get { return patronymic; } set { patronymic = value; } }

        internal DateTime BirthDate 
        { 
            get {  return birthDate; } 
            set 
            { 
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Birth date cannot be greater than current date.");
                }
                birthDate = value.Date; 
            } 
        }

        internal Age Age
        {
            get
            {
                TimeSpan span = DateTime.Now - birthDate;
                DateTime dateTime = DateTime.MinValue + span;
                return new Age(dateTime.Year - 1, dateTime.Month - 1, dateTime.Day - 1);
            }
        }
    }
}
