using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Services
{
    public class OddOrEvenServices
    {
        public string sentence = "";
        public int convertedNum;
        public bool runs;

        public string OddOrEven(string num)
        {
            runs = int.TryParse(num, out convertedNum);
            if (runs == false)
            {
                sentence = "Please enter a number";
            }
            else
            {

                if (convertedNum % 2 == 0)
                {
                    sentence = "The number " + num + " is even";
                }
                else if (convertedNum % 2 != 0)
                {
                    sentence = "The number " + num + " is odd";
                }

            }

            return sentence;
        }
    }
}