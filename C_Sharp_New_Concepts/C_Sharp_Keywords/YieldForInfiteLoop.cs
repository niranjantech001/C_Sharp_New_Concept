//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_New_Concepts.C_Sharp_Keywords
//{
//    class YieldForInfiteLoop
//    {

//        static void Main()
//        {
//            IEnumerable<int> GenrateWithoutYield()
//            {


//                var i = 0;

//                List<int> li = new List<int>();

//                while (true)

//                    li.Add(i++);

//                return li;
//            }

//            IEnumerable<int> GenrateWithYield()
//            {

//                var i = 0;
//                while (true)
//                yield return ++i;


                         

//            }


//            foreach (var item in GenrateWithoutYield().Take(5))
//            {

//                Console.WriteLine(item);

//            }
//            foreach (var item in GenrateWithYield().Take(5))
//            {

//                Console.WriteLine(item);
//            }


//        }
//    }
//}
