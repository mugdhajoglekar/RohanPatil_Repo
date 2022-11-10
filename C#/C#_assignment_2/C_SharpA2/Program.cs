namespace CsharpString
{
    using System;
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    class C_Sharp_A2
    {
        public static void Main(string[] args)
        {
            //Calling the method and printing output for Q1
            //Console.WriteLine("Check if 'rohan@gmail.com' a valid email ID valid ? = " + ValidateEmail.Validate1("rohan@gmail.com"));
            //Console.WriteLine("Check if 'rohanhotmail-com' a valid email ID valid ? = " + ValidateEmail.Validate1("rohanhotmail-com"));

            //4. Write a C# Program to Read a Text File.
            //ReadFile readFile = new ReadFile();
            //readFile.Read();

            //Write a C# program that demonstrates NullReference, DivideByZero, StackOverFlow, Generic exceptions.
            /*try
            {
                ExceptionDemo E = new ExceptionDemo();
                E = null;
                E.check();
                ExceptionDemo2 D = new ExceptionDemo2();
                D.check2();
            }
            //For NullReference
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("NullReference");
            }
            //for DivideByZero
            /*catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("DivideByZero");
            }*/

            //6.Write a C# Program to demonstrate the use of Generic classes and methods.
            //GenericClass obj = new GenericClass();
            //Calling Generics method
            //obj.Display<int>("Integer", 122);
            //obj.Display<char>("Character", 'H');
        }
    }

//1.	Write a C# program to validate an Email ID using – 
//a.Using Regex
    static class ValidateEmail
    {
        public static Boolean Validate1(string email)
        {
            string checker = @"^(\w+)@(\w+).([a-z]+)$";
            Match match = Regex.Match(email, checker);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
//Write a C# program that demonstrates NullReference, DivideByZero, StackOverFlow, Generic exceptions.
//for NullReference
    public class ExceptionDemo
    {
        public void check()
        {
            Console.WriteLine("Hello World");
        }
    }
//for DivideByZero
public class ExceptionDemo2
    {
        public void check2()
        {
            int a=8;
            int b=0;
            Console.WriteLine(a/b);
        }
    }

//4. Write a C# Program to Read a Text File.
public class ReadFile
{
    String data;
    public void Read()
    {
        StreamReader sr = new StreamReader(@"C:\Users\Rohan.P\Desktop\Rohan GitHub\RohanPatil_Repo\C#\C#_assignment_2\C_SharpA2\readfile.txt");
        data = sr.ReadLine();
        Console.WriteLine(data);
    }
}

    //6. Write a C# Program to demonstrate the use of Generic classes and methods.
    public class GenericClass
    {
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }

    }
}