using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Manager : AbstractEmployer
    {
        private string _ManagerialStatus;

        public string ManagerialStatus
        {
            get
            {
                return _ManagerialStatus;
            }

            set
            {
                _ManagerialStatus = value;
            }
        }
    }
}