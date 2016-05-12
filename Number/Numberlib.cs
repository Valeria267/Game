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
        private int k;
        

        public GNumber()
        {
           this.number = new Random().Next(0,101);
            k = 3;
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
            return UserNumber == number;
        }
    
        
        public bool Correct(int UserNumber)
        {
            bool result = false;

            if ((UserNumber >= 0) && (UserNumber <= 100))
            {
                result = true;
            }
           

            return result;
        }


        public bool Evaluation(int UserNumber)
        {
            bool result = false;
            k--;

            if (UserNumber < number)
            {
                result = true;
            }
          

            return result;
        }

        public bool Attempt(int UserNumber)
        {
            bool result = false;
            if (k > 0)
            {
                result = true;
            }
          
            return result;
        }
    }
}