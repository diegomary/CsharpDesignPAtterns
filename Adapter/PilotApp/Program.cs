using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterDP;

namespace PilotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // first we use the adaptee object to get the result as it is
           RandomGenerator rn = new RandomGenerator();
           int[] result= rn.Calculate();

            // Second we use the adapter to get the result in double which is what we need
           IRandomElaboration rna = new RandomGeneratorAdapter();
           double[] resultinDouble= rna.Elaborator();

        }
    }
}
