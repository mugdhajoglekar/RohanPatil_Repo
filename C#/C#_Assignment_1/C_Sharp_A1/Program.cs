//1.Write a C# program that performs all string operations like COMPARE, CONCAT, SUBSTRING, REVERSE using – 
//a.	Manual Array operations for character array ‘char[]’
//b.Built -in functions for ‘string’ variables

namespace CsharpString
{
    using System;
    using System.Text.RegularExpressions;
    enum PopRank
    {
        India,
        USA,
        Japan,
        France,
        Australia,
        England
    }
    class C_Sharp_A1
    {
        public static void Main(string[] args)
        {
            string str1 = "Luffy";
            string str2 = "Shanks";
            string str3 = "Shanks";
            string concated = string.Concat(str1 + str2);
            Boolean checkEqual = str1.Equals(str2);
            Boolean checkEqual1 = str2.Equals(str3);
            Console.WriteLine("Concated string is = " + concated);
            Console.WriteLine("Is str1 equal to str 2? = " + checkEqual);
            Console.WriteLine("Is str2 equal to str 3?  = " + checkEqual1);
            Console.WriteLine("Reverse the string through a function we get = " + StringReverse.ReverseString("Rohan"));
            Console.WriteLine("We can get substring by passing starting nad ending index in a function is = " + str1.Substring(0, 3));
            
            static string ReverseStr(string inp)
            {
                char[] inpArr = inp.ToCharArray();
                string reverse = String.Empty;
                for (int i = inpArr.Length - 1; i > -1; i--)
                {
                    reverse += inpArr[i];
                }
                return reverse;
            }
            Console.WriteLine("Reverse the string using custom logic we get = " + ReverseStr("Rohan"));
            
            static string CompareString(string inp1, string inp2)
            {
                char[] inpArr1 = inp1.ToCharArray();
                char[] inpArr2 = inp2.ToCharArray();
                string outp = String.Empty;
                Boolean check = false;
                for (int i = 0; i < inpArr1.Length; i++)
                {
                        if (inpArr1[i] == inpArr2[i])
                        {
                            check = true; 
                            continue;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                if(check==true)
                {
                    outp="Equal";
                }
                else
                {
                    outp="Not Equal";
                }
                return outp;
            }
            Console.WriteLine("Compare two strings using custom logic, Are given two strings 'string1' & 'string1' equal = " + CompareString("string1", "string1"));
            Console.WriteLine("Compare two strings using custom logic, Are given two strings 'string1' & 'string2' equal = " + CompareString("string1", "string2"));
            
            static string SubStr(string inp, int start, int end)
            {
                char[] inpArr = inp.ToCharArray();
                int s = start;
                int e = end;
                string strOut="";
                for (int i = s; i < e; i++)
                { 
                    strOut=strOut+inpArr[i];
                }
                return strOut;
            }
            Console.WriteLine("To get the substring using custom logic = " + SubStr("Rohan", 0, 3));
            
            // For que no 2

            Console.WriteLine("Is 'rohan@gmail.com' a valid email ID valid ? = " + ValidateEmail.Validate1("rohan@gmail.com"));
            Console.WriteLine("Is 'rohanhotmail-com' a valid email ID valid ? = " + ValidateEmail.Validate1("rohanhotmail-com"));

            //3.Write a C# program that demonstrates the use of Enums for countries – INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND

            Console.WriteLine("Population Ranking of France in given coutries is " +
                                    ((int)PopRank.France + 1));
            Console.WriteLine("Population Ranking of Japan in given coutries is " +
                                    ((int)PopRank.Japan + 1));
            Console.WriteLine("Population Ranking of England in given coutries is " +
                                    ((int)PopRank.England + 1));
            Console.ReadLine();
        }
    }
    static class StringReverse
    {
        public static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

 //2.Write a C# program to validate an Email ID using – 
//a.	Custom logic with loop & conditions
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
}



