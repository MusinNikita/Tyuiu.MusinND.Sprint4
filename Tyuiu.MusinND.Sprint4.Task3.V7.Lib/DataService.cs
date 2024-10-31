using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task3.V7.Lib
{
    public class DataService : ISprint4Task3V7
    {
        public int Calculate(int[,] array)
        {
            int count = 0; // Переменная для подсчета нечетных элементов

            // Проходим по всем элементам двумерного массива
            for (int i = 0; i < array.GetLength(0); i++) // Проходим по строкам
            {
                for (int j = 0; j < array.GetLength(1); j++) // Проходим по столбцам
                {
                    if (array[i, j] % 2 != 0) // Проверяем, является ли элемент нечетным
                    {
                        count++; // Увеличиваем счетчик
                    }
                }
            }

            return count; // Возвращаем количество нечетных элементов
        }
    }
}