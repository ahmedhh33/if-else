namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            //bool c;
            int c = 5;
            //Console.WriteLine(c);

            if(a<b || c==5) // must one condition true two extcude 
            {
                Console.WriteLine("condition met ");
            }
            //else if(a>b)
            //{
            //    Console.WriteLine("if else condition met ");
            //}
            else
            {
                Console.WriteLine(" else condition met ");
            }

            if (a < b && c == 5) // must two condition true two extcude 
            {
                Console.WriteLine("and condition met ");
            }
            else
            {
                Console.WriteLine(" and condition not met ");
            }

            Console.WriteLine("conditions types");
            int t=1,y=4,z=5;
            if (t<y && y<=z)
            {
                Console.WriteLine("that is great ");
            }
            else
            { Console.WriteLine("try ageen "); }
        }
    }
}