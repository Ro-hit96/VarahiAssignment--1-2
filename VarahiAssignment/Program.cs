//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace VarahiAssignment
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            HashSet<int> distinctTerms = new HashSet<int>();

//            for (int a = 2; a <= 5; a++)
//            {
//                for (int b = 2; b <= 5; b++)
//                {
//                    int result = (int)Math.Pow(a, b);
//                    distinctTerms.Add(result);
//                }
//            }

//            // Convert HashSet to an array and sort it
//            int[] sortedDistinctTerms = new int[distinctTerms.Count];
//            distinctTerms.CopyTo(sortedDistinctTerms);
//            Array.Sort(sortedDistinctTerms);

//            // Print the sorted distinct terms
//            Console.WriteLine("Sequence of distinct terms:");
//            foreach (int term in sortedDistinctTerms)
//            {
//                Console.WriteLine(term);
//            }
//        }
//    }
//}
