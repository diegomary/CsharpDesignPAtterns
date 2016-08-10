using System;


namespace AdapterDP
{
    // The adaptee class
    public class RandomGenerator
    {
        protected  const int amount = 1000;
        public int[] Calculate()
        {
            Random rnd = new Random();
            int[] nm = new int[amount];
            for (int i = 0; i < amount; i++) nm[i] = rnd.Next(0, amount + 1);
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
            double[] doubleRandoms = new double[amount];
            for(int y= 0; y < integersRandom.Length;y++)
            {
                doubleRandoms[y] = integersRandom[y] + rnd.NextDouble();

            }
            return doubleRandoms;

        }
    }








}
