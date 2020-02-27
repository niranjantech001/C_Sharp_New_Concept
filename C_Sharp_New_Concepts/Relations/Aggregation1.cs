using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aggregation1
    {
        //Aggregation is a direct relation between objects in C#. It is the relationship between objects.

        //For example, Student and Student Address.

        //An Employee is associated with a single Department, whereas a Department can have more than one employee
        public static void Main()
        {
            Adderess objAddress = new Adderess("Btm", "Bangalore", "Karnataka");
            Student objstudent = new Student(102, "Nirnajan", objAddress);
            objstudent.Display();
            Console.ReadKey();
        }

    }

    public class Adderess
    {
        public string Addresslane, City, State;

        public Adderess(string addlan,string City,string State)
        {
            this.Addresslane = addlan;
            this.City = City;
            this.State = State;
        }



    }

    public class Student
    {

        public string name;
        int id;
        static int batch = 2019;
        static string Course = "Btech";
        Adderess objAddreess;
        public Student(int Id,string Name,Adderess adderess)
        {

            this.id = Id;
            this.name = Name;
            this.objAddreess = adderess;


        }

        public void Display()
        {
            Console.WriteLine(id+""+name+""+objAddreess.Addresslane+""+objAddreess.City);

        }

    }
    
}
