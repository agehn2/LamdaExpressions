using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LamdasAndLinq
{

   
    class Program
    {
        static void Main(string[] args)
        {
            
            //1
            Func<string> Hello = () => "Hello World";
            Console.WriteLine($"{Hello()}");
            //2
            Func<int, int> AddOne = x => (x++);
            Console.WriteLine($"{AddOne(2)}");
            //3
            Func<int, int, int> PowerOf =(x, y) => (int)Math.Pow(y, x);
            Console.WriteLine($"{PowerOf(4, 2)}");
            //4
            Func<int, int, int> AddOneMore = (x, y)  => x + x;
            Console.WriteLine($"{AddOneMore(2, 2)}");
            //5
            Func<string, string, string > AppendStrings = (x, y) => x += y;
            Console.WriteLine($"{AppendStrings("Hello", "There")}");
            

            //var ListOfInts = new List<int> {1, 2, 3, 4, 5 };
            var ListOfStrings = new List<string> {"Hey", "Hi", "Hello", "Bonjour"};
            IEnumerable<int> ListOfInts =  Enumerable.Range(1, 5);

            //6
            ListOfInts.ToList().Add(AddOne(6));
           // ListOfInts(ListOfInts);
            var listafteraddone = ListOfInts.Select(AddOne);
            foreach (var Int in listafteraddone)
            {
                Console.WriteLine($"{6}.{Int}, ");
            }

            //7
            var listafterpow = ListOfInts.Select(x=>PowerOf(2,x));


            foreach (var Int in listafterpow)
            {
                Console.WriteLine($"{7}.{Int}");
            }

            //8

            var SumOfNumbers = ListOfInts.Aggregate(AddOneMore);
            Console.WriteLine($"{8}.{SumOfNumbers}");
            









        }

        static void ReadList(List<string> a)
        {
            foreach (var word in a)
            {
                Console.WriteLine(word);    
            }
        }

        static void ReadListInts <T>(List<T> a)
        {
            foreach (var word in a)
            {
                Console.WriteLine(word);
            }
        }
    }
}
