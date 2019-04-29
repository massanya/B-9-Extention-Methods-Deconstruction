using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
		{
			Coordinates coord = new Coordinates(11, 12, 33);
			var (X, Y, Z, vector) = coord;
			Console.WriteLine(vector);
			Console.ReadKey();
		}
		public struct Coordinates
		{
			private int x, y, z;

			public Coordinates(int x, int y, int z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}

			public void Deconstruct(out int X, out int Y, out int Z, out double vector)
			{
				X = x;
				Y = y;
				Z = z;
				vector =Math.Round(Math.Sqrt(X*X+Y*Y+Z*Z),2);
			}
		}

	

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
	        currentHour
			DateTime date = new DateTime();
	        var (_, _, _, currentHour, currentMinute, _) = date;
	        Console.WriteLine(currentHour + " " + currentMinute);
		}
        public static class ExtentionDateTime
        {
	        public static void Deconstruct(out int year, out int month, out int day, out int hour, out int minute, out int second)
	        {
		        year = DateTime.Now.Year;
		        month = DateTime.Now.Month;
		        day = DateTime.Now.Day;
		        hour = DateTime.Now.Hour;
		        minute = DateTime.Now.Minute;
		        second = DateTime.Now.Second;
	        }
        }
	}
}
