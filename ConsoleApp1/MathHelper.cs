using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MathHelper
    {
        public static decimal ConvertSqInchesToSqFeet(decimal squareInches)
        {
            return squareInches / 144M;
        }
    }
}
