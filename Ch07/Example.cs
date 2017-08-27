using System;

namespace ProCSharp.Ch07
{
    public class Example
    {
        public static void Run()
        {
            // 运算符重载
            /*Vector vect1, vect2, vect3;
            
            vect1 = new Vector(3.0, 3.0, 1.0);
            vect2 = new Vector(2.0, -4.0, -4.0);
            vect3 = vect1 + vect2;
            
            Console.WriteLine("vect1 = " + vect1.ToString());
            Console.WriteLine("vect2 = " + vect2.ToString());
            Console.WriteLine("vect3 = " + vect3.ToString());*/

            // stuff to demonstrate arithmetic operations
            /*Vector vect1, vect2, vect3;
            vect1 = new Vector(1.0, 1.5, 2.0);
            vect2 = new Vector(0.0, 0.0, -10.0);

            vect3 = vect1 + vect2;
            
            Console.WriteLine("vect1 = " + vect1);
            Console.WriteLine("vect2 = " + vect2);
            Console.WriteLine("vect3 = vect1 + vect2 = " + vect3);
            Console.WriteLine("2 * vect3 = " + 2 * vect3);
            vect3 += vect2;
            Console.WriteLine("vect1+=vect2 gives" + vect3);
            vect3 = vect1 * 2;
            Console.WriteLine("Setting vect3=vect1 * 2 gives" + vect3);
            double dot = vect1 * vect3;
            Console.WriteLine("vect1 * vect3 = " + dot);*/

            // 比较运算符重载
            /*Vector vect1, vect2, vect3;
            vect1 = new Vector(3.0, 3.0, -10.0);
            vect2 = new Vector(3.0, 3.0, -10.0);
            vect3 = new Vector(2.0, 3.0, 6.0);
            
            Console.WriteLine("vect1==vect2 returns " + (vect1 == vect2));
            Console.WriteLine("vect1==vect3 returns " + (vect1 == vect3));
            Console.WriteLine("vect2==vect3 returns " + (vect2 == vect3));
            
            Console.WriteLine();
            
            Console.WriteLine("vect1!=vect2 returns " + (vect1 != vect2));
            Console.WriteLine("vect1!=vect3 returns " + (vect1 != vect3));
            Console.WriteLine("vect2!=vect3 returns " + (vect2 != vect3));*/

            // 强制类型转换
            /*try
            {
                Currency balance = new Currency(50, 35);
                Console.WriteLine(balance);
                Console.WriteLine("balance is " + balance);
                Console.WriteLine("balance is (using ToString()) " + balance.ToString());

                float balance2 = balance;
                Console.WriteLine("After converting to float, = " + balance2);

                balance = (Currency) balance2;
                Console.WriteLine("After converting back to Currency, = " + balance);

                Console.WriteLine("Now attempt to convert out of range value of " +
                                  "-$50.50 to a Currency:");
                checked
                {
                    balance = (Currency) (-50.50);
                    Console.WriteLine("Result is " + balance.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred: " + e.Message);
            }*/

            // SimpleCurrency2
            try
            {
                Currency balance = new Currency(50, 35);
                
                Console.WriteLine(balance);  // SimpleCurrency2中可以直接强制转换为uint
                Console.WriteLine("balance is " + balance);
                Console.WriteLine("balance is (using ToString) " + balance.ToString());

                uint balance3 = (uint) balance;
                Console.WriteLine("Converting to uint gives " + balance3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}