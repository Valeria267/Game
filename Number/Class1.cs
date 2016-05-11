using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    public class GNumber
    {
        private int number;//задуманное число 
        private int k = 3;
        

        public GNumber()
        {
           this.number = new Random().Next(0,101);
        }

        public int Number
        {
            get
            {
                return number;
            }
        }
        public int K
        {
            get
            {
                return k;
            }
        }

        public bool NumberEquals(int UserNumber)
        {
            if (UserNumber == number)
                return true;

            else return false;
               
         }
    
        
        public bool Correct(int UserNumber)
        {
            if ((UserNumber >= 0) && (UserNumber <= 100))
             return true;
             else return false;
        }


        public bool Evaluation(int UserNumber)
        {
            k--;
            if (UserNumber<number)
                 return true; 
                else  return false; 
         }

        public bool Attempt(int UserNumber)
        {
            if (k > 0)
                return true;
            else return false;
        }
    }
}