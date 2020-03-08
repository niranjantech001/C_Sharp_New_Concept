using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_New_Concepts.Linq
{
    class Lambda_Expression
    {
        
        static void Main()
        {


            // Two Types of Expression


            // 1) Expression Lambda
            // 2) Statement Lambda



            // Expression Lambda 
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            int[] Numbers = { 2, 3, 4, 5 };

            var Square_Number=Numbers.Select(x=>)


            // Compare Two values

            Func<int, int, bool> EqualTest = (x, y) => x == y;

            Console.WriteLine(EqualTest(12,5));



            // Statement Lambda

            Action<string> Greet = name =>
              {
                  Console.WriteLine(name);

              };

            Greet("niranjan");

            Console.ReadKey();


        }
    }
}
