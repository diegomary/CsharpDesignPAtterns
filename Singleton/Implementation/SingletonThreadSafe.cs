// See clear explanation on thread safety
//https://msdn.microsoft.com/en-us/library/ff650316.aspx

using System;

namespace SingletonDp
{
    public sealed class SingletonThreadSafe
    {
        private static volatile SingletonThreadSafe instance;
        private static object syncRoot = new Object();

        private SingletonThreadSafe() { }

        public static SingletonThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SingletonThreadSafe();
                    }
                }

                return instance;
            }
        }
    }
}
