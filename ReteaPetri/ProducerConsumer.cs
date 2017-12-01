using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteaPetri
{
    class ProducerConsumer : PetriNetwork
    {
        List<Transition> transitionsList = new List<Transition>();
        List<Arc> tmpList = new List<Arc>();
        List<Arc> tmpList2 = new List<Arc>();
        List<Arc> tmpList3 = new List<Arc>();
        List<Arc> tmpList4 = new List<Arc>();
        List<Arc> tmpList5 = new List<Arc>();
        List<Arc> tmpList6 = new List<Arc>();
        List<Arc> tmpList7 = new List<Arc>();
        List<Arc> tmpList8 = new List<Arc>();
        static Location producers = new Location("producers", 100);
        static Location productReady = new Location("productready", 0);
        static Location pozitiiLibere = new Location("pozitiilibere", 10);
        static Location mutex = new Location("mutex", 1);
        static Location pozitiiOcupate = new Location("pozitiiocupate", 0);
        static Location consumers = new Location("consumers", 300);
        static Location dataReady = new Location("dataready", 0);
        
        
        Arc arcInProducers = new Arc(producers, 1, false);

        public ProducerConsumer()
        {
            Arc arcInProduce = new Arc(producers, 1, true);
            tmpList.Add(arcInProduce);
            Transition produceIn = new Transition("produce",tmpList);
            transitionsList.Add(produceIn);
            Arc arcOutProduce = new Arc(productReady, 1, false);
            tmpList2.Add(arcOutProduce);
            Transition produceOut = new Transition("produce", tmpList2);
            transitionsList.Add(produceOut);
            Arc arcInPush1 = new Arc(productReady, 1, true);
            Arc arcInPush2 = new Arc(pozitiiLibere, 1, true);
            Arc arcInPush3 = new Arc(mutex, 1, true);
            tmpList3.Add(arcInPush1);
            tmpList3.Add(arcInPush2);
            tmpList3.Add(arcInPush3);
            Transition pushIn = new Transition("push", tmpList3);
            transitionsList.Add(pushIn);
            Arc arcOutPush1 = new Arc(pozitiiOcupate, 1, false);
            Arc arcOutPush2 = new Arc(mutex, 1, false);
            Arc arcOutPush3 = new Arc(producers, 1, false);
            tmpList4.Add(arcOutPush1);
            tmpList4.Add(arcOutPush2);
            tmpList4.Add(arcOutPush3);
            Transition pushOut = new Transition("push", tmpList4);
            transitionsList.Add(pushOut);
            Arc arcInPop1 = new Arc(pozitiiOcupate, 1, true);
            Arc arcInPop2 = new Arc(mutex, 1, true);
            Arc arcInPop3 = new Arc(consumers, 1, true);
            tmpList5.Add(arcInPop1);
            tmpList5.Add(arcInPop2);
            tmpList5.Add(arcInPop3);
            Transition popIn = new Transition("pop", tmpList5);
            transitionsList.Add(popIn);
            Arc arcPopOut1 = new Arc(mutex, 1, false);
            Arc arcPopOut2 = new Arc(pozitiiLibere, 1, false);
            Arc arcPopOut3 = new Arc(dataReady, 1, false);
            tmpList6.Add(arcPopOut1);
            tmpList6.Add(arcPopOut2);
            tmpList6.Add(arcPopOut3);
            Transition popOut = new Transition("pop", tmpList6);
            transitionsList.Add(popOut);
            Arc arcConsumeIn = new Arc(dataReady, 1, true);
            tmpList7.Add(arcConsumeIn);
            Transition consumeIn = new Transition("consume", tmpList7);
            transitionsList.Add(consumeIn);
            Arc arcConsumeOut = new Arc(consumers, 1, false);
            tmpList8.Add(arcConsumeOut);
            Transition consumeOut = new Transition("consume", tmpList8);
            transitionsList.Add(consumeOut);
            InitList(transitionsList);
        }

        public override bool Execute(string action)
        {
            return base.Execute(action);
        }
    }
}

