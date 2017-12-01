using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class Transition
    {
        private List<Arc> _arcs = new List<Arc>();
        private string _tag;

        public Transition(string tag, List<Arc> arcs)
        {
            _tag = tag;
            _arcs = arcs;

        }
        public bool IsValid()
        {
            bool status = true;
            for (int i = 0; i < _arcs.Count; i++)
            {
                if (_arcs.ElementAt(i).IsValid() == false)
                {
                    status = false;
                    break;
                }
            }
            if (status == true)
            {
                Console.WriteLine("Transition " + _tag + " executed");
                return true;
            }
            else
            {
                Console.WriteLine("Transition " + _tag + " didn't executed");
                return false;
            }
        }

        public void Execute()
        {
            if (IsValid() == true)
            {
                for (int i = 0; i < _arcs.Count; i++)
                {
                    _arcs.ElementAt(i).Update();
                }
            }
        }
        public string ReturnTag()
        {
            return _tag;
        }
    }
}
