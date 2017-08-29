using System;
using ProCSharp.Ch07;

namespace ProCSharp.Ch08
{
    public class Example
    {
        private delegate string GetAString();

        delegate double DoubleOp(double x);

        public static void Run()
        {
            /*int x = 40;
            GetAString firstStringMethod = new GetAString(x.ToString);
            Console.WriteLine("String is {0}", firstStringMethod());
            // With firstStringMethod initialized to x.ToString(),
            // the above statement is equivalent to saying
            // Console.WriteLine("String is {0}", x.ToString());*/

            /*int x = 40;
            GetAString firstStringMethod = x.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());
            
            Currency balance = new Currency(34, 50);
            
            // firstStringMethod references an instance method
            firstStringMethod = balance.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());
            
            // firstStringMethod references a static method
            firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
            Console.WriteLine("String is {0}", firstStringMethod());*/
            
            // 简单的委托示例
            /*Func<double, double>[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]:", i);
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }*/
            
            // BubbleSort
            Employee[] employees =
            {
                new Employee("Bugs Bunny", 20000),
                new Employee("Elmer Fudd", 10000),
                new Employee("Daffy Duck", 25000),
                new Employee("Wile Coyote", 1000000.38m),
                new Employee("Foghorn Leghorn", 23000),
                new Employee("RoadRunner", 50000)
            };
            BubbleSorter.Sort(employees, Employee.CompareSalary);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        static void ProcessAndDisplayNumber(Func<double, double> action, double value)
        {
            double result = action(value);
            Console.WriteLine(
                "Value is {0}, result of operation is {1}", value, result);
        }
    }
}