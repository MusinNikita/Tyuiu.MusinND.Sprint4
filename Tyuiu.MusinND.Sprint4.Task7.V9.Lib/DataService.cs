using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task7.V9.Lib
{
    public class DataService : ISprint4Task7V9
    {
        public int Calculate(int n, int m, string value)
        {
            // Проверка, достаточно ли символов в строке для создания матрицы
            if (value.Length < n * m)
            {
                throw new ArgumentException("Строка не содержит достаточного количества цифр для формирования матрицы.");
            }

            // Создаем матрицу с помощью Array
            var matrix = Array.CreateInstance(typeof(int), n, m);
            int evenCount = 0; // Счетчик четных чисел

            // Заполняем матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Преобразуем символ в целое число и заполняем матрицу
                    int valueToInsert = value[i * m + j] - '0'; // Конвертируем символ в целое число
                    matrix.SetValue(valueToInsert, i, j); // Устанавливаем значение в матрицу

                    // Проверяем, является ли число четным
                    if (valueToInsert % 2 == 0)
                    {
                        evenCount++; // Увеличиваем счетчик четных чисел
                    }
                }
            }

            return evenCount; // Возвращаем количество четных чисел
        }
    }
}