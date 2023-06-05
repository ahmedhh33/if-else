namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            bool c;
            c = a == b;
            Console.WriteLine(c);

            if(a!=b)
            {
                Console.WriteLine("condition met ");
            }
            else if(a>b)
            {
                Console.WriteLine("if else condition met ");
            }
            else
            {
                Console.WriteLine(" else condition met ");
            }
        }
    }
}