using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class PetriNetwork
    {
        private List<Transition> _transitions = new List<Transition>();
        private Transition transition;
        public virtual bool Execute(string action)
        {          
            bool status = false;
            for (int i = 0; i < _transitions.Count; i++)
            {
                transition = _transitions.ElementAt(i);
                if (transition.ReturnTag().Equals(action))
                {
                    transition.Execute();
                    status = true;
                }
            }
            if (status == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void InitList(List<Transition> transitions)
        {
            _transitions = transitions;
        }
    }
}
