using System;


namespace AdapterDP
{
    // The adaptee class
    // This class produces Integers random numbers in 
    public class RandomGenerator
    {
       
        public int LowerLimit { get; set; }
        public int HigherLimit { get; set; }
        public int Amount { get; set; }

        public int[] Calculate()
        {
            Random rnd = new Random();
            int[] nm = new int[Amount];
            for (int i = 0; i < Amount; i++) nm[i] = rnd.Next(LowerLimit, HigherLimit + 1);
            return nm;
        }

    }


    public interface IRandomElaboration
    {
        double[] Elaborator();
    }

    // The adapter which inherits the adaptee and implement the specific interface
    public class RandomGeneratorAdapter : RandomGenerator, IRandomElaboration
    {
        public double[] Elaborator()
        {
            Random rnd = new Random();
            int[] integersRandom = Calculate();
            double[] doubleRandoms = new double[Amount];
            for(int y= 0; y < integersRandom.Length;y++)
            {
                doubleRandoms[y] = integersRandom[y] + rnd.NextDouble();

            }
            return doubleRandoms;

        }
    }








}
