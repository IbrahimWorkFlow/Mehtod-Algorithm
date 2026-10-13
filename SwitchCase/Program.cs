using System.Runtime.InteropServices;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void IsDivided3(int a, int b)
        {
            for(int i = a; i != b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void IsComposite(int a)
        {
            for(int i = 2; i != a/2; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("Murekkeb");
                }
                else
                {
                    Console.WriteLine("Sade");
                }
            }
        }

        public int IsMax(int a = 7481)
        {
            int max = 0;


            while (a != 0)
            {
                if (a % 10 > max)
                {
                    max = a % 10;
                }

                a = a / 10;
            }

            return max;
        }

        public void IsPower(int a = 8)
        {
            bool result = true;  
            while (a != 0)
            {
                if (a % 2 != 0)
                {
                    result = false;
                }
                a = a / 2;
            }

            if (result)
            {
                Console.WriteLine("Quvvetidir");
            }
            else
            {
                Console.WriteLine("Quvveti deyil");

            }
        }

    }
}
