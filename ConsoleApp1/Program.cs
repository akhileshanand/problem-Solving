// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Dynamic;
using System.Text;
using System.Xml;

namespace ConsoleApp
{
    public class Client
    {

        static void Main(string[] args)
        {
            /* 1.Given a string S return a string after removing 3 consecutive 3chars.
                 Input = "eedaaad";
                 Output = "eedaad"
             */
            /* Solution =====> 
                   string s = "eedaaad";
                   Console.WriteLine(s);
                   solution(out s);
            */
            //=====================================================================
            /* 2.print consucutive number and print "Power" where number is the power of 2
             * Input = 8
             * Output = 1 , 2,3, Power, 5,6,7,Power
                 Solution ===============> ProblemSolution();
            */
            //==========================================================================
            /* 3.Reverse a string:-
               Input = "I am Ram"
               Output = "Ram am I"
                Solution ===============>StrReverse();
             */
            //========================================================================
            /* there is a array of sting . Find the duplicte element in an array and also find the number of 
             * times it is duplicated.
               SOlution================>  FindDuplicateStringInArray();
             */



            //================================================================
            /* Question based on oops concept asked in Open text
            Shape[] shape = new Shape[5];
            shape[0] = new Shape(10, 20); //--> This is base class constructor
            shape[0].GetPosition(); //-->The position of the shape is x- {0}, y -{ 1} ", pos_x, pos_y

            shape[0].DrawObject(); //--> Drawing the Shapes

            shape[1] = new Circle(20, 30); //--> This is base class constructo
            shape[1].GetPosition(); //--> The position of the Circle is x- {0}, y -{ 1} ", pos_x, pos_y

            shape[1].DrawObject();// --> Drawing Circle
            shape[1].CalculateRadius(); //--> Calling the radius of Circle method
            shape[2] = new Diamond(); //--> This is derived class Diamond static constructor
            ((Circle)shape[1]).DrawObject(); //--> Drawing Circle

            ((Circle)shape[1]).GetPosition(); // --> he position of the Circle is x- {0}, y -{ 1} ", pos_x, pos_y
           */

        }
        public static void ProblemSolution()
        {
            int N = 1000;
            int j = 0;
            for (int i = 1; i <= N; i++)
            {
                double x = Math.Pow(2, j);
                //  Console.WriteLine(x);
                if (i == x)
                {
                    Console.WriteLine("Power");
                    j++;
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
        public static void solution(out string S)
        {
            S = "hdkjshkj";
            Stack<char> stk = new Stack<char>();
            int C = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (stk.Count == 0)
                {
                    stk.Push(S[i]);
                    C++;
                }
                else if (stk.Peek() == S[i] && C < 2)
                {
                    stk.Push(S[i]);
                    C++;
                }
                else if (stk.Peek() != S[i])
                {
                    C = 0;
                    stk.Push(S[i]);
                    C++;
                }
            }
            StringBuilder result = new StringBuilder();
            while (stk.Count != 0)
            {
                result.Append(stk.Pop());
            }
            Console.WriteLine(result.ToString().Reverse().ToArray());
        }
        public static void StrReverse()
        {
            Console.WriteLine("Input string");
            string s1 = Console.ReadLine();
            Stack<string> stk = new Stack<string>();
            string[] s2 = s1.Split(" ");
            for (int i = 0; i < s2.Length; i++)
            {
                stk.Push(s2[i]);
            }
            StringBuilder result = new StringBuilder();
            while (stk.Count != 0)
            {
                result.Append(stk.Pop());
                result.Append(' ');
            }
            Console.WriteLine("Output String");
            Console.WriteLine(result.ToString().ToArray());
        }

        public static void FindDuplicateStringInArray()
        {
            List<string> arr = new List<string>();
            arr.Add("hi");
            arr.Add("hello");
            arr.Add("hi");
            arr.Add("sjk");
            arr.Add("hi");
            arr.Add("hello");

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < arr.Count; i++)
            {
                int count = 1;
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], count);
                }
                else
                {
                    dict.TryGetValue(arr[i], out count);
                    count++;
                    dict[arr[i]] = count;
                }
            }
            foreach (var item in dict)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item);
                }


            }

        }
    }
}
