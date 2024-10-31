using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            // Используем метод Array.FindAll для фильтрации элементов
            string[] result = Array.FindAll(array, item => item.Length > 5);
            return result; // Возвращаем отфильтрованный массив
        }
    }
}