using System;
using System.Security.Claims;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initilize Class and Objects
            Console.WriteLine("Initilize Class and Objects");
            ClassPractice obj = new ClassPractice();
            Console.WriteLine("Hello World!");
            obj.PrintColor();

            //Creating multiple objects of same Class
            Console.WriteLine("Creating multiple objects of same Class");
            Multipleobject multipleobject = new Multipleobject();
            Multipleobject obj1= new Multipleobject();
            Multipleobject obj2= new Multipleobject();
            obj1.PrintColor("yellow");
            obj2.PrintColor("blue");


            //Initailaize object with empty values
            Console.WriteLine("Initailaize object with empty values");
            ClassMembers obj3= new ClassMembers(); 
            obj3.StudentDetails("Test",10);
            ClassMembers obj4 = new ClassMembers();
            obj4.StudentDetails("wardha",23);

        }
    }
}
