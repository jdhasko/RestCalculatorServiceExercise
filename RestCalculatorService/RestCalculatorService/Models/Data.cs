using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCalculatorService.Models
{
    public class Data
    {

        public Data() { }
        public Data(int numberA, int numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }

        public int NumberA { get; set; }
        public int NumberB { get; set; }




    }
}
