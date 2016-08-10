// See clear explanation on thread safety
//https://msdn.microsoft.com/en-us/library/ff650316.aspx

namespace SingletonDp
{
    using System;
    using System.Collections.Generic;

    public sealed class SingletonStaticInitialization : ISingletonStaticInitialization
    {
        private static readonly ISingletonStaticInitialization instance = new SingletonStaticInitialization();
        private object locker;
        private static Random rnd = new Random();
        public static List<ResponseTimeSample> allResponseTimes;
        private SingletonStaticInitialization()
        {
            locker = new object();
            allResponseTimes = new List<ResponseTimeSample>();
                  
        }

        public void CalculateLatency()
        {           
                int[] responseTime = new int[10]; 
                for (int j = 0; j < responseTime.Length; j++)
                {
                    responseTime[j] = rnd.Next(1, 71); // response time between 1ms and 70 ms this is the place where the latency can be calculated
                }
                ResponseTimeSample rst =                                                                         new ResponseTimeSample() { Sample = responseTime };
                lock (locker) {allResponseTimes.Add(rst);} // The global resource must be protected by cuncurrency
        }

        public static SingletonStaticInitialization Instance
        {
            get
            {
                return (SingletonStaticInitialization)instance;
            }
        }
    }


}
