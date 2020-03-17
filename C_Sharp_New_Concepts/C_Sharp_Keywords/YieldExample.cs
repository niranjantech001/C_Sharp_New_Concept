//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_New_Concepts.C_Sharp_Keywords
//{
//    class YieldExample
//    {

//        static void Main()
//        {



//                IEnumerable<int> GenrateWithoutYield()
//            {

//                var i = 0;
//                var li = new List<int>();

//                while(i<5)
               
//                    li.Add(i++);

//                    return li;
                
//            }

//            foreach (var item in GenrateWithoutYield())
//            {

//                Console.WriteLine(item);
//            }

//            IEnumerable<int> GenerateWithYield()
//            {
//                var i = 0;

//                while(i<5)
               

//                    yield return i++;
                
                


//            }

//            foreach (var item in GenerateWithYield())
//            {

//                Console.WriteLine(item);

//            }

//            Console.ReadKey();


//        }
//    }
//}

