using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
            int product = 1; // Инициализация произведения
            bool hasOdd = false; // Флаг для проверки наличия нечетных элементов

            foreach (int num in array)
            {
                if (num % 2 != 0) // Проверяем, является ли число нечетным
                {
                    product *= num; // Умножаем нечетное число на произведение
                    hasOdd = true; // Устанавливаем флаг, что нечетные элементы найдены
                }
            }

            return hasOdd ? product : 0; // Если нечетных элементов не было, возвращаем 0
        }
    }
}