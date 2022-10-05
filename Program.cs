namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x1 = (byte)5;
            short x2 = (short)5;
            int x3 = 5;
            long x4 = 5l;
            Console.WriteLine(x1 + "  " + x1.GetType() + "\n" + WholeNumbers(x1));
            Console.WriteLine(x2 + "  " + x2.GetType() + "\n" + WholeNumbers(x2));
            Console.WriteLine(x3 + "  " + x3.GetType() + "\n" + WholeNumbers(x3));
            Console.WriteLine(x4 + "  " + x4.GetType() + "\n" + WholeNumbers(x4));


            float x5 = 5.1f;
            double x6 = 5.1;
            Console.WriteLine(x5 + "  " + x5.GetType() + "\n" + RealNumbers(x2));
            Console.WriteLine(x6 + "  " + x6.GetType() + "\n" + RealNumbers(x2));








            DateTime dtEnd = new DateTime(2022, 12, 31);
            DateTime dtStart = new DateTime(2022, 1, 1);

            DateTime dtnow = DateTime.Now;

            TimeSpan DifferenceStart = dtnow - dtStart;
            TimeSpan DifferenceEnd = dtEnd - dtnow;

            Console.WriteLine($@"
{DifferenceEnd.Days} days left to New Year

{DifferenceStart.Days} days passed from New Year
");








        }

        static string WholeNumbers(long x)
        {

            int y = 1;
            var x1 = -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15;
            var x2 = Math.Abs(x) * Math.Sin(x);
            var x3 = 2 * Math.PI * x;
            var x4 = Math.Max(x, y);

            return $@"x1={x1}  
x2={x2}  
x3={x3}  
x4={x4}  
---------------------------------
";
        }
        static string RealNumbers(double x)
        {

            int y = 1;
            var x2 = Math.Abs(x) * Math.Sin(x);
            var x3 = 2 * Math.PI * x;
            var x4 = Math.Max(x, y);

            return $@"

x2={x2} 
x3={x3}  
x4={x4} 
---------------------------------
";

        }


    }
}
