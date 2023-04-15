using System;

namespace Assignment
{
    public class SUV_TESTS
    {

        public int IsLeap(int num)
        {
            if (num > 1753 && num < 9999)
            {


                if (num % 400 == 0 || num % 100 != 0)
                {
                    return 1;
                }
                else if (num % 4 == 0 || num % 100 != 0)
                {

                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;   
            }
        }
    }
}
