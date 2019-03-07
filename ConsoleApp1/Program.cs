using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        bool Guess(int[] vec, int val)
        {
            foreach (var value in vec)
            {
                if (value == val) {
                    return true;

                }
            }
            return false;
        }
    }
}
