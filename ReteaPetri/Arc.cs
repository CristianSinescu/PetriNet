using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class Arc
    {
        private Location _location;
        private int _capacity;
        private bool _direction;

        public Arc(Location location, int capacity, bool direction)
        {
            _location = location;
            _capacity = capacity;
            _direction = direction;
        }

        public bool IsValid()
        {
            if(_direction == true && _location.ReturnNumberOfJetons() >= _capacity)
            {
                return true;

            }else if(_direction == false)
            {
                return true;

            }else
            {
                return false;
            }
        }
        public void Update()
        {
            if (_direction == true)
            {
                _location.Extract(_capacity);
            }
            else
            {
                _location.Add(_capacity);
            }
        }

    }
}
