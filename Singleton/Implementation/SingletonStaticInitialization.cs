// See clear explanation on thread safety
//https://msdn.microsoft.com/en-us/library/ff650316.aspx

namespace SingletonDp
{
    using System;
    using System.Collections.Generic;

    public sealed class SingletonStaticInitialization
    {
        private static readonly SingletonStaticInitialization instance = new SingletonStaticInitialization();
        private int[] responseTime;
        public static List<int> allResponseTimes;
        private SingletonStaticInitialization()
        {
            responseTime = new int[10];
            allResponseTimes = new List<int>();
            Random rnd = new Random();           
        }

        public void CalculateLatency()
        {
            Random rnd = new Random();
            for (int j = 0; j < responseTime.Length; j++)
            {
                responseTime[j] = rnd.Next(1, 71); // response time between 1ms and 70 ms
            }
            allResponseTimes.AddRange(responseTime);

        }

        public static SingletonStaticInitialization Instance
        {
            get
            {
                return instance;
            }
        }
    }


}
