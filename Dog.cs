using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAnimal.Models
{
    internal record Dog:Animal
    {
        private string _name;
        private string _breed;

        public Dog()
        {
            _name = Name;
            _breed = Breed;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length>1 && value.Length <= 10)
                {
                    _name = value;
                }
            }
        }

        public string Breed
        {
            get { return _breed; }
            set
            {
                if (value.Length>2 && value.Length <= 15)
                {
                    _breed = value;
                }
            }
        }
    }
}
