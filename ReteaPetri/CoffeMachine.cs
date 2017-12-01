using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class CoffeMachine :PetriNetwork
    {
        List<Transition> list = new List<Transition>();

       public CoffeMachine()
        {
            AddToList("0", 1, 1, true, "5");
            AddToList("5", 0, 1, false, "5");
            AddToList("0", 1, 1, true, "10");
            AddToList("5", 1, 1, true, "5");
            AddToList("10", 0, 1, false, "10");
            AddToList("5", 1, 1, true, "10");
            AddToList("10", 0, 1, false, "5");
            AddToList("10", 1, 1, true, "5");
            AddToList("15", 0, 1, false, "5");
            AddToList("15", 0, 1, false, "10");
            AddToList("10", 1, 1, true, "C10");
            AddToList("15", 1, 1, true, "C15");
            AddToList("0", 0, 1, false, "C10");
            AddToList("0", 0, 1, false, "C15");
            InitList(list);
        }

        public override bool Execute(string action)
        {
            return base.Execute(action);
        }

        public void AddToList(string locationTag, int locationNoOfJ, int arcCapacity, bool arcDirection, string transitionTag)
        {
            Location location = new Location(locationTag, locationNoOfJ);
            Arc arc = new Arc(location, arcCapacity, arcDirection);
            List<Arc> arcs = new List<Arc>();
            arcs.Add(arc);
            Transition transition = new Transition(transitionTag, arcs);
            list.Add(transition);
        }
    }
}
