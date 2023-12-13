using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_Person.Classes
{
    internal class Person
    {
        private string _name;
        private int _height;
        private int _weight;
        public string Name { get { return _name; } set { _name = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }

        public Person(string name, int heigt, int weight) 
        { 
            _name = name;
            _height = heigt;
            _weight = weight;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Height: {_height}, Weight: {_weight}";
        }

    }
}
