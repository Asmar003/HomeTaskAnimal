using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAnimal.Models
{
    internal record Animal
    {
        string _gender;
        int _birthYear;

        public Animal()
        {
            _gender = Gender;
            _birthYear=BirthYear;
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
               
            }
        }

        public int BirthYear
        {
            get 
            {
                DateTime date = DateTime.Now;
                _birthYear=date.Year;
                return _birthYear; 
            }
            set
            {
                _birthYear = value;
              
            }
        }


    }
}
