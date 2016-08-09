using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDp
{
  public  class ResponseTimeSample
    {
        private int[] _sample;
        public int[] Sample
        {
            get { return _sample; }
            set { _sample=value; }
        }

    }
}
