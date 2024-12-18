using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);

            List<int> ints2; //= new List<int>();
            //List<int> ints3 = new List<int>();

            //int num = ints[0];
            //num = 321;

            //Console.WriteLine(ints[0]);
            ints2 = ints;
            //ints2 = ints3;

            //Console.WriteLine(ints2[0]);
            //ints2[0] = 321;
            //Console.WriteLine(ints[0]);

            foreach (int i in ints2)
                Console.WriteLine(i);


            Console.WriteLine("음 흠?");
            Console.WriteLine("????");

            List<example> exampleList = new List<example>();
            exampleList.Add(new example { a = 1 });
            Console.WriteLine(exampleList[0].a);


            example example = exampleList[0];
            example = new example { a = 2 };

            Console.WriteLine(exampleList[0].a);
            Console.WriteLine(example.a);

            Console.WriteLine("아니 이게된다고고ㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗㅗ");
        }
    }

    public class example
    {
        public int a;
    }
}
