using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_New_Concepts.C_Sharp_Keywords
{
    public class TestNew
    {

        public void Method(out int Answer, out string Message, out string StilllNull)
        {
            Answer = 44;
            Message = "Test";
            StilllNull = null;



        }
    }
    class OutKeyword
    {

        static void Main()
        {
            TestNew obj = new TestNew();

            int argNumber;
            string argmesage, argdefult;
            obj.Method(out argNumber,out argmesage,out argdefult);

            Console.WriteLine(argNumber);
            Console.WriteLine(argmesage);
            Console.WriteLine(argdefult);

            Console.ReadKey();
        }
    }

  


   


}