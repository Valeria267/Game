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

       
        public string NumberEquals(int UserNumber)
        {
            if (UserNumber == number)
                return "You won";
            
            else
                  { if ((UserNumber >= 0) && (UserNumber <= 100))
                {
                    if (k <= 1)
                    {
                        return null;
                    }
                    if (UserNumber < number)
                    { k--; return "More. Remaining " + k + " attempts"; }
                    else { k--; return "Less. Remaining " + k + " attempts"; }
                }
                else return "incorrect values";
                  }
         }

    }
}