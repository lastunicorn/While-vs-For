using System;

namespace WhileVsFor
{
    public class Class1
    {
        public void Method1()
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(".");

                i++;
            }
        }

        public void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(".");
            }
        }
    }
}
