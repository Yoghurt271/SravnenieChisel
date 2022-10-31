using System;

namespace Sravnenie
{
    class Program
    {
		static void Main(string[] args)
		{
			double min = 0, max = 0, avar = 0; // Инициализация переменных которые пригодяться в будущем
			double a, b, c;

			Console.WriteLine("Введите три числа");

			try
			{
				a = Convert.ToDouble(Console.ReadLine());
				b = Convert.ToDouble(Console.ReadLine()); // Ввод чисел
				c = Convert.ToDouble(Console.ReadLine());

				// Сравнение чисел

				if (a <= b && a <= c)
				{
					min = a;
				}

				else if (b <= a && b <= c)
				{
					min = b;
				}

				else if (c <= a && c <= b)
				{
					min = c;
				}

				if (a >= b && a >= c)
				{
					max = a;
				}

				else if (b >= a && b >= c)
				{
					max = b;
				}

				else if (c >= a && c >= b)
				{
					max = c;
				}

				if (a <= b && a >= c)
				{
					avar = a;
				}

				else if (a >= b && a <= c)
				{
					avar = a;
				}

				else if (b <= a && b >= c)
				{
					avar = b;
				}

				else if (b >= a && b <= c)
				{
					avar = b;
				}

				else if (c <= a && c >= b)
				{
					avar = c;
				}

				else if (c >= a && c <= b)
				{
					avar = c;
				}

                Console.WriteLine(min + " <= " + avar + " <= " + max); // Вывод результата на консоль
            }


			catch // При не верно введенных данныех выводиться сообщение
			{
				Console.WriteLine("Введите коректные данные");
			}
		}
	}
}
