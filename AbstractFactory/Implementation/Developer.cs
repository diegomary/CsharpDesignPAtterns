using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Developer : AbstractEmployer
    {
        private string _ItDeportmentCode;

        public string ItDeportmentCode
        {
            get
            {
                return _ItDeportmentCode;
            }

            set
            {
                _ItDeportmentCode = value;
            }
        }
    }
}