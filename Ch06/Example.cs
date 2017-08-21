using System;

namespace ProCSharp.Ch06
{
    public class Example
    {
        public static void Run()
        {
            /*Person[] myPersons =
            {
                new Person {FirstName = "Ayrton", LastName = "Senna"},
                new Person {FirstName = "Michael", LastName = "Schumacher"}
            };

            int[,] twodim =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int[,,] threedim =
            {
                {{1, 2}, {3, 4}},
                {{5, 6}, {7, 8}},
                {{9, 10}, {11, 12}}
            };
            
            Console.WriteLine(threedim[0, 1, 1]);*/

            /*int[][] jagged = new int[3][];
            jagged[0] = new int[2] {1, 2};
            jagged[1] = new int[6] {3, 4, 5, 6, 7, 8};
            jagged[2] = new int[3] {9, 10, 11};

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int element = 0; element < jagged[row].Length; element++)
                {
                    Console.WriteLine("row: {0}, element: {1}, value: {2}",
                        row, element, jagged[row][element]);
                }
            }*/

            /*Person[] persons =
            {
                new Person {FirstName = "Damon", LastName = "Hill"},
                new Person {FirstName = "Niki", LastName = "Lauda"},
                new Person {FirstName = "Ayrton", LastName = "Senna"},
                new Person {FirstName = "Graham", LastName = "Hill"}
            };

//            Array.Sort(persons);
            Array.Sort(persons, new PersonComparer(PersonCompareType.FirstName));
            foreach (var p in persons)
            {
                Console.WriteLine(p);
            }*/

            /*int[] ar1 = {1, 4, 5, 11, 13, 18};
            int[] ar2 = {3, 4, 5, 18, 21, 27, 33};
            
            var segments = new ArraySegment<int>[2]
            {
                new ArraySegment<int>(ar1, 0, 3),
                new ArraySegment<int>(ar2, 3, 3)
            };
            var sum = SumOfSegments(segments);
            Console.WriteLine("SumOfSegments: {0}", sum);*/
            
            var helloCollection = new HelloCollection();
            helloCollection.HelloWorld();
        }

        static int SumOfSegments(ArraySegment<int>[] segments)
        {
            int sum = 0;
            foreach (var segment in segments)
            {
                for (int i = segment.Offset; i < segment.Offset + segment.Count; i++)
                {
                    sum += segment.Array[i];
                }
            }
            return sum;
        }
    }
}