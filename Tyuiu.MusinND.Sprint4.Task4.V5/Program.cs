using Tyuiu.MusinND.Sprint4.Task4.V5.Lib;
namespace Tyuiu.MusinND.Sprint4.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Мусин Никита Денисович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Мусин Никита Денисович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значения*");
            Console.WriteLine("*ями с клавиатуры в диапазоне от 3 до 9. Найдите сумму четных элементов ма*");
            Console.WriteLine("*ассива. 6, 3, 6, 6, 7, 9, 8, 9, 7, 9, 5, 6, 8, 7, 5, 8, 5, 6, 5, 3, 3, 9,*");
            Console.WriteLine("*, 9, 8, 8                                                                *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.YOURFUNCTION();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}