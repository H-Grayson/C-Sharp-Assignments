using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Methods
    {
        public static int Math(int Num)
        {
            int result = Num + 10;
            return result;
        }

        public static decimal Math(decimal Num)
        {
            int result = (int)(Num * 10);
            return result;
        }

        public static int Math(string Num)
        {
            int NumConv = Convert.ToInt32(Num);
            int result = (NumConv / 5);
            return result;
        }
    }
}
