using System;
using System.Collections;

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
            
            /*var titles = new MusicTitles();
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            
            Console.WriteLine("reverse");
            foreach (var title in titles.Reverse())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            
            Console.WriteLine("subset");
            foreach (var title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }*/
            
            /*var game = new GameMoves();
            IEnumerator enumerator = game.Cross();  // 将枚举器设置为由game.Cross()返回的枚举器类型
            while (enumerator.MoveNext())  // enumerator.MoveNext()会调用Cross()方法，Cross()方法返回另一个枚举器
            {
                enumerator = enumerator.Current as IEnumerator;  // 返回的值可以用Current属性访问
            }*/

            /*var result = Divide(5, 2);
            Console.WriteLine("result of division: {0}, reminder: {1}",
                result.Item1, result.Item2);*/
            
            var janet = new Person { FirstName = "Janet", LastName = "Jackson" };
            Person[] person1 =
            {
                new Person { FirstName = "Michael", LastName = "Jackson" },
                janet
            };
            Person[] person2 =
            {
                new Person { FirstName = "Michael", LastName = "Jackson" },
                janet
            };
            if (person1 != person2)
                Console.WriteLine("not the same reference");
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

        public static Tuple<int, int> Divide(int dividend, int divisor)
        {
            int result = dividend / divisor;
            int reminder = dividend % divisor;

            return Tuple.Create<int, int>(result, reminder);
        }
    }
}