using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task5.V22.Lib
{
    public class DataService : ISprint4Task5V22
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0; // Переменная для подсчета отрицательных элементов

            // Проходим по всем элементам двумерного массива
            for (int i = 0; i < matrix.GetLength(0); i++) // Проходим по строкам
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Проходим по столбцам
                {
                    if (matrix[i, j] < 0) // Проверяем, является ли элемент отрицательным
                    {
                        count++; // Увеличиваем счетчик
                    }
                }
            }

            return count; // Возвращаем количество отрицательных элементов
        }
    }
}