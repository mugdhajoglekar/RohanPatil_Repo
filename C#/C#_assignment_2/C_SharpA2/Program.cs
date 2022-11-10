namespace CsharpString
{
    using System;
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    using System.Linq;
    class C_Sharp_A2
    {
        public static void Main(string[] args)
        {
            //Calling the method and printing output for Q1
            Console.WriteLine("Check if 'rohan@gmail.com' a valid email ID valid ? = " + ValidateEmail.Validate1("rohan@gmail.com"));
            Console.WriteLine("Check if 'rohanhotmail-com' a valid email ID valid ? = " + ValidateEmail.Validate1("rohanhotmail-com"));
            Console.WriteLine("----------------------------------------------------------------------");
            //4. Write a C# Program to Read a Text File.
            ReadFile readFile = new ReadFile();
            readFile.Read();
            Console.WriteLine("----------------------------------------------------------------------");
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

            //3. Write a C# Program to Display the Student Details using Select Clause LINQ.
            StudentDetails StudObj = new StudentDetails();
            StudObj.DisplayStudent();
            Console.WriteLine("----------------------------------------------------------------------");

            //6.Write a C# Program to demonstrate the use of Generic classes and methods.
            GenericClass obj = new GenericClass();
            //Calling Generics method
            obj.Display<int>("Integer", 12);
            obj.Display<char>("Character", 'R');
            Console.WriteLine("----------------------------------------------------------------------");

            //5. Write a C# Program to sort a list of employees based on salary in descending order and whose department is XYZ 
            //function call
            EmpDetails empDetails = new EmpDetails();
            empDetails.EmpDesc();
            Console.WriteLine("----------------------------------------------------------------------");
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

//5. Write a C# Program to sort a list of employees based on salary in descending order and whose department is XYZ 
public class EmpDetails
    {
        string EmpName, EmpDep;
        int EmpSal;
        public void EmpDesc()
        {
            List<EmpDetails> employeeSalaries = new List<EmpDetails>()
            {
            new EmpDetails{EmpName = "Raju", EmpSal = 40000, EmpDep = "XYZ"},
            new EmpDetails{EmpName = "Sanku", EmpSal = 31000, EmpDep = "XYZ"},
            new EmpDetails{EmpName = "Dhana", EmpSal = 33700, EmpDep = "ABC"},
            new EmpDetails{EmpName = "Rohan", EmpSal = 33700, EmpDep = "XYZ"},
            };
            var result_set = employeeSalaries.Where(emp => emp.EmpDep == "XYZ").OrderByDescending(sal => sal.EmpSal);
            Console.WriteLine("-------Employeee-------");
            foreach (EmpDetails emp in result_set)
            {
                Console.WriteLine(emp.EmpName + " " + emp.EmpSal + " " + emp.EmpDep);
            }
        }
    }
}

//3. Write a C# Program to Display the Student Details using Select Clause LINQ.
class StudentDetails
{
    int StudentRN, StudentResult;
    string StudentName, StudentDiv, StudentCity;
    public void DisplayStudent()
    {
        List<StudentDetails> s = new List<StudentDetails>()
            {
                new StudentDetails{ StudentRN = 1, StudentDiv = "CE2", StudentName = "Rohan", StudentResult = 89, StudentCity = "Shirpur"},
                new StudentDetails{ StudentRN = 2, StudentDiv = "CE2", StudentName = "Raj", StudentResult = 69, StudentCity ="Manjrod" },
                new StudentDetails{ StudentRN = 3, StudentDiv = "CE3",StudentName = "Yashodhan", StudentResult = 35, StudentCity = "Shirpur"},
                new StudentDetails{ StudentRN = 4, StudentDiv = "CE1",StudentName = "Sanket", StudentResult = 85, StudentCity = "Varshi"},
            };
        IEnumerable<StudentDetails> Query = from student in s select student;

        Console.WriteLine("---------------Student Details--------------");
        foreach (StudentDetails e in Query)
        {
            Console.WriteLine(e.StudentRN + "   " + e.StudentDiv + "   " + e.StudentName + "   " + e.StudentResult + "   " + e.StudentCity);
        }
    }
}




