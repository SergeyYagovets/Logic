using System;
using System.Collections.Generic;

namespace Task
{
   public class Logic
   {
        private const int N = 6;
        public static double L;  
        public static double H;
        public static double Alfa;

        public static Points A = new Points();


        public class Points
        {
           public double X { get; set; }
           public double Y { get; set; }
           public Points(double x, double y)
           {
                X = Math.Round(x, 2);
                Y = Math.Round(y, 2);
           }
           public Points()
           {              
           }
        }
        public static List<Points> GetAllPoints() {

        List<Points> points = new List<Points>();

            for (int i = 0; i <= 8; i++)
            {
                switch (i)
                {
                    case 0:
                        points.Add(new Points(A.X, A.Y));
                        break;
                    case 1:
                        points.Add(new Points((L / N) + A.X, A.Y));
                        break;
                    case 2:
                        points.Add(new Points((3 * (L / N)) + A.X, A.Y));
                        break;
                    case 3:
                        points.Add(new Points((5 * (L / N)) + A.X, A.Y));
                        break;
                    case 4:
                        points.Add(new Points(L + A.X, H + A.Y));
                        break;
                    case 5:
                        points.Add(new Points((4 * (L / N)) + A.X, A.X + (2 * (L / N) * Math.Tan(Alfa * Math.PI / 180)) + H));
                        break;
                    case 6:
                        points.Add(new Points((3 * (L / N)) + A.X, A.X + (3 * (L / N) * Math.Tan(Alfa * Math.PI / 180)) + H));
                        break;
                    case 7:
                        points.Add(new Points((2 * (L / N)) + A.X, A.X + (2 * (L / N) * Math.Tan(Alfa * Math.PI / 180)) + H));
                        break;
                    case 8:
                        points.Add(new Points(A.X, H + A.Y));
                        break;
                }
            }
            return points;
        }

        static void Main(string[] args)
        {
            A.X = 0;
            A.Y = 0;
            List<Points> points = GetAllPoints();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Симметричная шарнирно-стержневая схема.");
          
            Console.Write($"Введите высоту: H = ");
            H = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите длину: L = ");
            L = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите угол в градусах Alfa: = ");
            Alfa = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Исходные данные: (A (x) = {A.X}), (A (y) = {A.Y}), (H = {H}), (L = {L}), (Alfa = {Alfa})");
            Console.ReadLine();

            foreach (var point in points )
            {
                Console.WriteLine($"x = {point.X}, y = {point.Y}");
            }
            Console.ReadLine();
        }
    }

}
