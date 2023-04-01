using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_27
{
	struct NOTE
	{
		public string name;
		public string surname;
		public int tele;
		public int day;
		public int month;
		public int year;
		

		public NOTE(string Name, string Surname, int Tele, int Day, int Month, int Year)
		{
			this.name = Name;
			this.surname = Surname;
			this.tele = Tele;
			this.day = Day;
			this.month = Month;
			this.year = Year;
		}
		public override string ToString()
		{
			return (string.Format(@"           
			Имя: {0} 
            Фамили: {1} 
            Телефон: {2}
            Дата рождения: {3}.{4}.{5} ", name, surname, tele, day, month, year));
			
		
		
		
		}
	}





	class Program
	{
		static void Main(string[] args)
		{
			int a = 3; 
			NOTE[] mas = new NOTE[a];
			for (int i = 0; i < a; i++)
			{
				Console.Write("Введите имя: ");
				mas[i].name = Console.ReadLine();
				Console.Write("Введите фамилию: ");
				mas[i].surname = Console.ReadLine();
				Console.Write("Введите телефон: ");
				mas[i].tele = int.Parse(Console.ReadLine());
				Console.Write("Введите ДЕНЬ рождения: ");
				mas[i].day = int.Parse(Console.ReadLine());
				Console.Write("Введите МЕСЯЦ рождения: ");
				mas[i].month = int.Parse(Console.ReadLine());
				Console.Write("Введите ГОД рождения: ");
				mas[i].year = int.Parse(Console.ReadLine());
			}
			for(int i=0;i<2;i++)
			{
				for (int j = 0; j < a - 1 - i; j++)
				{
					if (mas[i].year > mas[j].year)
					{
						NOTE temp = mas[i];
						mas[i] = mas[j];
						mas[j] = temp;
					}
				}
			}
			Console.WriteLine("Информация о людях (отсортированная по дате рождения): ");
			for (int i = 0; i < a; i++)
			{
				Console.WriteLine(mas[i]);
			}
			string flag;
			Console.WriteLine("Введите фамилию человека: ");
			flag = Console.ReadLine();
			for (int i = 0; i < a; i++)
			{
				if (mas[i].surname == flag)
				{
					Console.WriteLine(mas[i]);
				}
				else Console.WriteLine("такого челка нет");
				break;
			}

			Console.ReadKey();

		}

	}
}