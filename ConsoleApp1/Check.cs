using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Check
    {

        public  bool CheckMod(int n)
        {
            if (n % 2 != 0) return false;
            while ( n/2 > 2)  
                {
                int x = n / 2;
                if (x == 2) return true;
                else
                {
                    if (x % 2 == 1) return false;
                    n = x;
                }
                }
                return true;
         
        }
            
            
           
            
       
    }
}
