using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisBas
{
    public class FisBas
    {
       public string CheckNumber(double number)
        {
            string getNumber;
            
            if(number%3==0&&number%5==0)
            {
                return "FisBas";
            }
            if (number % 3 == 0)
            {
                return "Fis";
            }
            if (number % 5 == 0)
            {
                return "Bas";
            }
            else
            {
                getNumber = Convert.ToString(number);
                return getNumber;
            }
            
        }
    }
}
