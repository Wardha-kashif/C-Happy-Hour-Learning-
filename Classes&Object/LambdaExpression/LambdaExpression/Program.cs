using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int mymethod(int a, int b, int c, int d)
    {
        return a * b * c * d;
    }
    static void Main()
    {
        /// Lambda Expression

        // expression lambda that returns the square of a number 
        var square = (int num) => num * num;
        // passing input to the expression lambda 
        Console.WriteLine("Square of number: " + square(5));
        var Sum = (int num1, int num2) => num1 + num2;
        Console.WriteLine("The sum of two numbers is" + Sum(10, 10));

        ///C# - Func Delegate

        // Using Func delegate
        // Here, Func delegate contains
        // the four parameters of int type
        // one result parameter of int type
        Func<int, int, int, int, int> val = mymethod;
        Console.WriteLine(val(10, 100, 1000, 1));


        /// OrderBy and OrderByDesending usage in C#
        IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
};
        //Sort in Ascending Order
        Console.WriteLine("Sort in Ascending Order");
        var studentData = studentList.OrderBy(x => x.StudentName);
        foreach (var std in studentData)
        {
            Console.WriteLine(std.StudentName);
        }

        //Sort in Descending Order
        Console.WriteLine("Sort in Descending Order");
        var studentDataInDescendingOrder = studentList.OrderByDescending(x => x.StudentName);
        foreach (var std in studentDataInDescendingOrder)
        {
            Console.WriteLine(std.StudentName);
        }
    }
}

internal class Student
{
    public Student()
    {
    }
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}