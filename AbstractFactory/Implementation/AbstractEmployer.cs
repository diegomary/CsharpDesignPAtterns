using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractEmployer
    {
        private int _id;
        private string _name;
        private string _email;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Email
        {
            get
            {
                return Email;
            }

            set
            {
                _email = value;
            }
        }
    }
}