using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_PRACTISE.C_OOPS;

namespace C_PRACTISE
{
    //Single inheritance from Animal base parent class from C#OOPS
    internal class AnimalsMammals2 : Animals
    {
      
        public void Mammals2Characteristics()
        {
            Flight();
            Physiology();

        }

        private static void Flight()
        {
            Console.WriteLine("Birds possess pneumatic (hollow) bones to reduce weight and modified forelimbs that have evolved into wings");

        }

        private static void Physiology()
        {
            Console.WriteLine("Birds are endothermic, which highlights the importance of homeostasis in allowing them to inhabit extreme climates. ");

        }

    }
}
