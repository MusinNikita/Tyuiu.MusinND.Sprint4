using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusinND.Sprint4.Task0.V16.Lib
{
    public class DataService : ISprint4Task0V16
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int product = 1;
            bool hasEven = false; // Флаг для проверки, есть ли четные элементы

            foreach (int num in array)
            {
                if (num % 2 == 0) // Проверяем, является ли число четным
                {
                    product *= num; // Умножаем четное число на произведение
                    hasEven = true; // Устанавливаем флаг, что четные элементы найдены
                }
            }

            return hasEven ? product : 0; // Если четных элементов не было, возвращаем 0
        }
    } 
}
