namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1, b = 1;
            ////bool c;
            //int c = 5;
            ////Console.WriteLine(c);

            //if(a<b || c==5) // must one condition true two extcude 
            //{
            //    Console.WriteLine("condition met ");
            //}
            ////else if(a>b)
            ////{
            ////    Console.WriteLine("if else condition met ");
            ////}
            //else
            //{
            //    Console.WriteLine(" else condition met ");
            //}

            //if (a < b && c == 5) // must two condition true two extcude 
            //{
            //    Console.WriteLine("and condition met ");
            //}
            //else
            //{
            //    Console.WriteLine(" and condition not met ");
            //}

            //Console.WriteLine("conditions types");
            //int t=1,y=4,z=5;
            //if (t<y && y<=z)
            //{
            //    Console.WriteLine("that is great ");
            //}
            //else
            //{ Console.WriteLine("try ageen "); }


            //Console.WriteLine("Nested loops");
            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine("i body ");
            //    Console.WriteLine(" i = " + i);
            //    for(int j=0; j<5; j++)
            //    {
            //       //Console.WriteLine("j body ");
            //        Console.WriteLine(" j = " + j);
            //    }
            //    Console.WriteLine(" after j loop");
            //}
            //Console.WriteLine(" Anuther nested loop: ");
            //for(int i=0; i<5;i++)
            //{
            //    for(int j=0; j<i;j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            Console.WriteLine("program that takes two inputs from users ard prints all even and odd numbers ");
            Console.WriteLine("Enter the vale of starting number = ");
            int st = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the vale of ending number = ");
            int en = int.Parse(Console.ReadLine());
            Console.WriteLine("******************");
            for (int i = st; i <= en; i++)
            {
                //Console.WriteLine((2*i)+1);
                if (i % 2 != 0)
                {
                    Console.WriteLine("Odd - " + i);
                }
                else
                    Console.WriteLine("Even - " + i);
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}