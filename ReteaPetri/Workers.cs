using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class Workers :PetriNetwork
    {
        List<Transition> list = new List<Transition>();

        public Workers()
        {
            AddToList("workers", 100, 1, true, "startread");
            AddToList("reading", 0, 1, false, "startread");
            AddToList("reading", 1, 1, true, "endread");
            AddToList("workers", 99, 1, false, "endread");
            AddToList("workers", 100, 100, true, "startwrite");
            AddToList("writing", 0, 1, false, "startwrite");
            AddToList("writing", 1, 1, true, "endwrite");
            AddToList("workers", 0, 100, false, "endwrite");
           
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
