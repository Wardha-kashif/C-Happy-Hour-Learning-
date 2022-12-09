using System;
using System.Net.Security;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

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


            //Constructor 
            Console.WriteLine("Constructor");
            ConstructorPractice obj5 = new ConstructorPractice("Testing user");
            ConstructorExample Ford = new ConstructorExample("Mustang", "Red", 1969);

            //Encapsulation
            Console.WriteLine("Encapsulation");
            Encapsulation obj6= new Encapsulation();
            obj6.Name = "Test Encalpsulation";
            Console.WriteLine(obj6.Name);


            //Inheritance
            Console.WriteLine("Inheritance");
            Child obj7= new Child();
            obj7.printDetails();
            Console.WriteLine(obj7.modelname);
            Console.WriteLine(obj7.brand);

            //Polymorphism
            Console.WriteLine("Polymorphism");
            Animal obj9= new Animal();
            Animal obj10= new Dog();
            Animal obj11= new Cat();
            obj9.animalSound();
            obj10.animalSound();
            obj11.animalSound();

            //Abstraction
            Console.WriteLine("Abstraction");
            Mango obj12 = new Mango();
            obj12.getDetails();
            obj12.FruitColour();

            //Interface
            Console.WriteLine("Interface");
            Parrot obj13 = new Parrot();
            obj13.birdSound();

            //Multiple Interface
            Console.WriteLine("Multiple Interface");
            ImplementInterface obj14 = new ImplementInterface();
            obj14.methodOne();
            obj14.methodTwo();


            //Enum
            Console.WriteLine("Enum");
            Level obj15 = Level.Low;
            Console.WriteLine(obj15);
            Console.WriteLine((int)obj15);

            //C# Files
            string writeText = "Hello World Data";
            File.WriteAllText("filetext.txt", writeText);

            string readText = File.ReadAllText("filetext.txt");
            Console.WriteLine(readText);


            //try,Catch
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

        }


    }
}
