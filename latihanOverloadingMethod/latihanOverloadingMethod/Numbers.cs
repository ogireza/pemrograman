using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanOverloadingMethod
{
    public class Numbers
    { 
        public int FindMin(int num1, int num2)
        {
            int result = 0;
            if (num1 < num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;

        }

        public int FindMin(int num1, int num2, float num3)
        {
        float result = 0;
            if (num1 < num2 && num1 < num3)
            {
                result = num1;
            } else if(num2 < num1 && num2 < num3)
            {
                result = num2;
            }
            else if (num3 < num1 && num3 < num2)
            {
                result = num3;
            }
            return (int)result;
        }
        
        public int FindMax(int num1, int num2)
        {
        int result = 0;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        public int FindMax(int num1, int num2, float num3)
        {
        float result = 0;
            if (num1 > num2 && num1 > num3)
            {
                result = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                result = num2;
            }
            else if (num3 > num1 && num3 > num2)
            {
                result = num3;
            }
            return (int)result;
            // end
        }
        
    }
}
