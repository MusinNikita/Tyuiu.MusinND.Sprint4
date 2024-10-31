using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task4.V5.Lib
{
    public class DataService : ISprint4Task4V5
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0; // Переменная для хранения суммы четных элементов

            // Проходим по всем элементам двумерного массива
            for (int i = 0; i < matrix.GetLength(0); i++) // Проходим по строкам
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Проходим по столбцам
                {
                    if (matrix[i, j] % 2 == 0) // Проверяем, является ли элемент четным
                    {
                        sum += matrix[i, j]; // Добавляем четное число к сумме
                    }
                }
            }

            return sum; // Возвращаем итоговую сумму
        }
    }
}