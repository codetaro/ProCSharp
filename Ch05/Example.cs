using System;
using System.Collections.Generic;

namespace ProCSharp.Ch05
{
    public class Example
    {
        public static void Run()
        {
            /*var list2 = new LinkedList<int>();
            list2.AddLast(1);
            list2.AddLast(3);
            list2.AddLast(5);

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            
            var list3 = new LinkedList<string>();
            list3.AddLast("2");
            list3.AddLast("four");
            list3.AddLast("foo");

            foreach (string s in list3)
            {
                Console.WriteLine(s);
            }*/

            /*var dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("Title A", "Sample A"));
            dm.AddDocument(new Document("Title B", "Sample B"));
            
            dm.DisplayAllDocuments();

            if (dm.IsDocumentAvailable)
            {
                Document d = dm.GetDocument();
                Console.WriteLine(d.Content);
            }*/

            /*IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();
            IIndex<Shape> shapes = rectangles;  // covariance <out T>

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i]);
            }
            
            IDisplay<Shape> shapeDisplay = new ShapeDisplay();
            IDisplay<Rectangle> rectangleDisplay = shapeDisplay;  // contravariance <in T>
            rectangleDisplay.Show(rectangles[0]);*/

            /*Nullable<int> x;
            x = 4;
            x += 3;  // operator '+=' cannot be applied to Nullable<int> and int
            if (x.HasValue)
            {
                int y = x.Value;
            }
            x = null;  // cannot convert null to Nullable<int>*/

            /*var accounts = new List<Account>()
            {
                new Account("Christian", 1500),
                new Account("Stephanie", 2200),
                new Account("Angela", 1800)
            };

            decimal amount1 = Algorithm.AccumulateSimple(accounts);
            decimal amount2 = Algorithm.Accumulate<Account>(accounts);
            decimal amount3 = Algorithm.Accumulate<Account, decimal>(
                accounts, (item, sum) => sum += item.Balance);
            Console.WriteLine("amount1 = {0}, amount2 = {1}, amount3 = {2}",
                amount1, amount2, amount3);*/
            
            var test = new MethodOverloads();
            test.Foo(33);
            test.Foo("abc");
            test.Bar(44);
        }
    }
}