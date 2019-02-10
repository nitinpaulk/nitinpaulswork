using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploringCSharp7.Interfaces;

namespace ExploringCSharp7
{
    public class Tuples : ITuples
    {
        public (int sum, int product) Math(int a, int b)
        {
            int c = a + b;
            int d = a * b;

            return (sum:c, product:d);
        }
    }
}
