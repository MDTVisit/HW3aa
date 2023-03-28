using System;

class Program
{
    static void Main()
    {
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double r1 = Convert.ToDouble(Console.ReadLine());
        double r2 = Convert.ToDouble(Console.ReadLine());

        double ar = r1+r2;
        double c1 = Math.Pow(x2 - x1, 2);
        double c2 = Math.Pow(y2 - y1, 2);

        A (x1,y1,x2,y2,r1,r2,ar,c1,c2);
    }

    static void A (double x1, double y1, double x2, double y2, double r1, double r2, double ar, double c1 , double c2)
    {
        double d = Math.Sqrt(c1 + c2);

        if(d <= ar)
        {
            double a = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (2 * d);
            double h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(a, 2));
            double x3 = x1 + a * (x2 - x1) / d;
            double y3 = y1 + a * (y2 - y1) / d;
            double x4 = x3 - h * (y2 - y1) / d;
            double y4 = y3 + h * (x2 - x1) / d;
            double x5 = x3 + h * (y2 - y1) / d;
            double y5 = y3 - h * (x2 - x1) / d;

            if(d == ar){
                Console.WriteLine(x4);
                Console.WriteLine(y4);
            }else{
                Console.WriteLine(x4);
                Console.WriteLine(y4);
                Console.WriteLine(x5);
                Console.WriteLine(y5);
            }
        }

    }
}