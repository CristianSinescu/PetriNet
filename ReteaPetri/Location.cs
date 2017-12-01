using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class Location
    {
        private string _tag;
        private int _numberOfJetons;

        public Location(string tag, int numberOfJetons)
        {
            _tag = tag;
            _numberOfJetons = numberOfJetons;
        }

        public void Extract(int value)
        {
            Console.WriteLine("Number of Jetons before extraction from location '"+_tag+"' is "+_numberOfJetons);
            _numberOfJetons -= value;
            Console.WriteLine("Number of Jetons after extraction from location '"+_tag+"' is "+_numberOfJetons);
        }
        public void Add(int value)
        {
            Console.WriteLine("Number of Jetons before adding in location '" + _tag + "' is " + _numberOfJetons);
            _numberOfJetons += value;
            Console.WriteLine("Number of Jetons after adding to location '" + _tag + "' is " + _numberOfJetons);
        }
        public int ReturnNumberOfJetons()
        {
            return _numberOfJetons;
        }
    }
}
