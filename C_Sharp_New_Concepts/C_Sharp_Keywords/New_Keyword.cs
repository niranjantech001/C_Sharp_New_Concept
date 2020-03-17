//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp_New_Concepts.C_Sharp_Keywords
//{
//    class New_Keyword
//    {

//        static void Main()
//        {


//            Derived obj = new Derived();
//            obj.Invoke();
//            obj.NotInvoke();

//            Console.ReadKey();

//        }

//    }

//    public class Basic
//    {
//        public int X { get; set; }

       

//        public void Invoke()
//        {
//        }

//        public void NotInvoke()
//        {

//        }

//    }

//    public class Derived:Basic
//    {

//        new public void Invoke()
//        {
//            Console.WriteLine("Its hidden by Using New Keyword");
//        }

//        public void NotInvoke()
//        {
//            Console.WriteLine("Nothing");
//        }

//    }
//}
