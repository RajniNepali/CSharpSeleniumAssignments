//Create the delegate and use the delegate in a program
using System;
using System.Collections.Generic;
delegate int NumberChanger(int n);
namespace Scripts1
{
    public class Assignment4
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        public void UsingDelegate(int num)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(num);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(num);
            Console.WriteLine("Value of Num: {0}", getNum());
           
        }
    }
}