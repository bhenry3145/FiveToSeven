using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Services
{
    public class ReverseItNumbersServices
    {
        public string sequence = "";
        public int reversedSequence;
        public int convertedNum;
        public string convertedNumString = "";
        public bool runs;
        public int remainder;
        public string convertedAgain = "0";

        public string ReverseItNum(string num)
        {
            runs = int.TryParse(num, out convertedNum);
            if (runs == false)
            {
                sequence = "Please enter a number";
            }
            else
            {
                convertedNumString = convertedNum.ToString();
                for (int i = 0; i < convertedNumString.Length; i++)
                {
                    int number = convertedNum % 10;
                    remainder = ((remainder*10) + number);
                    convertedNum = convertedNum / 10;
                    if (num.Length - 1 == 0){
                        convertedAgain += remainder;
                        sequence = "You entered " + convertedNumString + ", reversed is " + convertedAgain;
                        return sequence;
                    }
                    sequence = "You entered " + convertedNumString + ", reversed is " + remainder;
                }
                
            }
            return sequence;
        }


    }
}