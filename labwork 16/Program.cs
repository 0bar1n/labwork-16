using System;
using System.IO;

namespace labwork_16
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("d:/2 курс/аип 3 семестр/текстовые файлы к пр.16/kvur.txt"))
            {
                string[] mass = reader.ReadLine().Split(' ');
                int a = Convert.ToInt32(mass[0]);
                int b = Convert.ToInt32(mass[1]);
                int c = Convert.ToInt32(mass[2]);

                Console.WriteLine($"Квадратное уравнение имеет вид {a}x^2+{b}x+c=0");

                double x1, x2; //ввод данных
                
                var discriminant = Math.Pow(b, 2) - 4 * a * c;//дискриминант
                if (discriminant < 0)
                {
                    Console.WriteLine("Квадратное уравнение не имеет корней");
                }
                else
                {
                    if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                    {
                        x1 = -b / (2 * a);
                        x2 = x1;
                    }
                    else //уравнение имеет два разных корня
                    {
                        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    }
                    Console.WriteLine($"Корни уравнения {x1},{x2}");

                    StreamWriter w = new StreamWriter("d:/2 курс/аип 3 семестр/текстовые файлы к пр.16/korni.txt", true);
                     w.WriteLine($"{x1}");
                     w.WriteLine($"{x2}");
                     w.Close();
                } Console.WriteLine("данные введены в файл korni.txt"); 
                Console.ReadLine(); //программа ожидает нажатия клавиши для завершения работы
                
            } 

        }
    }
}
