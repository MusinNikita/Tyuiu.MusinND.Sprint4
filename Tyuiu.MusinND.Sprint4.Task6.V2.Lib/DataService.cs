using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            List<string> resultList = new List<string>(); // Список для хранения элементов длиной более 5 символов

            // Проходим по всем элементам массива
            foreach (string item in array)
            {
                if (item.Length > 5) // Проверяем, если длина элемента больше 5
                {
                    resultList.Add(item); // Добавляем элемент в список
                }
            }

            return resultList.ToArray(); // Преобразуем список в массив и возвращаем его
        }
    }
}