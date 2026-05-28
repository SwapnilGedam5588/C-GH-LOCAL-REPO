using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_PRACTISE.C_OOPS;

namespace C_PRACTISE
{
    //Single inheritance from Animal base parent class from C#OOPS
    internal class AnimalsMammals1 : Animals
    {
       

        public void Mammals1Characteristics()
        {
            warmblood();
            Vertebrates();
            GiveBirth();
        }

        private static void warmblood()
        {
            Console.WriteLine("They are usually known as homeothermic species");
        }

        private static void Vertebrates()
        {
            Console.WriteLine("have a spinal cord (hollow tube) which is connected via vertebrae.");

        }

        private static void GiveBirth()
        {
            Console.WriteLine("all mammals give birth to offspring.");
        }

    }
}



    


