using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class CreditCard
    {
        private string _number;
        public string Number
        {
            get { return _number; }
            // (value - string)
            set 
            {
                // Only change the value of _number
                // If length of value is exactly 16
                int lengthOfValue = value.Length;
                if (lengthOfValue == 16)
                {
                    _number = value; 
                }
            }
        }
    }
}
