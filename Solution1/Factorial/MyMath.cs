using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class MyMath
    {
        public static double Factorial(int n) {

            double factorial = 1;

            for (int i=2; i<=n; i++) {

                factorial *= i;

            
            }
            return factorial;

        }
    }
}
