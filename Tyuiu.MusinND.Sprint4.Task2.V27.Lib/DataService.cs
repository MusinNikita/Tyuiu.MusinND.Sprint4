using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task2.V27.Lib
{
    public class DataService : ISprint4Task2V27
    {
        public int Calculate(int[] array)
        {
            int sum = 0; // Переменная для хранения суммы четных элементов

            foreach (int num in array)
            {
                if (num % 2 == 0) // Проверяем, является ли число четным
                {
                    sum += num; // Добавляем четное число к сумме
                }
            }

            return sum; // Возвращаем итоговую сумму
        }
    }
}