using System.Data;
using System.Globalization;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization.Formatters;
using System.Xml;

namespace ArraysAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Массивы
            int[] asd1 = new int[3]; // Одномермерный массив
            int[,] asd = new int[3, 2] // Двухмерный массив
            {{1 ,4}, {-1, 2,}, {1, 2}}; // Иницилизация двумерного массива
            int[][] asd2 = new int[3][]; // Зубчатый массив (массив с массивами). В этом массиве 3 массива (исп-ся в логистике)
            asd2[0] = new int[] { }; // Инициализация зубчатого массива
                                     // row = asd.GetLength(0); // Размерность двумерного массива
                                     // Перебор элементов массива циклом foreach
            /*int[] ss = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in ss)
            {
                Console.WriteLine(i);
            }*/
            // У массивов есть методы и поля
            // Задача на кол-во элементов массива
            /*int[] arr = new int[] { 1, 23, 1234, 2, 3, 13, 33, 123, 123, 3, 41234, 123, 4423, 345345};
            int chet=0, nechet=0, unique=0; // Счётчики чётных/нечётных/уникальных
            foreach(var item in arr)
            {
                if (item % 2 == 0)
                    chet++; 
                else
                    nechet++;                 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }                        
                }
                if (isUnique)
                    unique++;
            }
            Console.Write("Кол-во чётных элементов = ");
            Console.WriteLine(chet);
            Console.Write("Кол-во нечётных элементов = ");
            Console.WriteLine(nechet);
            Console.Write("Кол-во уникальных элементов = ");
            Console.WriteLine(unique);
            Console.Write("Введите число -> ");            
            int num = Convert.ToInt32(Console.ReadLine()), counter = 0; // Запрос ввода числа и инициализация счётчика            
            foreach(var i in arr)
            {
                if (i < num)
                    counter++;
            }
            Console.Write("Кол-во элементов = ");
            Console.WriteLine(counter);*/
            /*int max = asd[0, 0];
            int min = asd[0, 0];
            // Первый способ через циклы for
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (asd[i, j] > max)
                       max = asd[i, j];
                    
                    if (asd[i, j] < min)                     
                        min = asd[i, j];                    
                }
            }
            // Второй способ через цикл foreach
            foreach (var i in asd)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
            }
            Console.Write("Максимальный элемент = ");
            Console.WriteLine(max);
            Console.Write("Минимальный элемент = ");
            Console.WriteLine(min);*/

            // Максимальный и минимальный элементы массива (решение преподавателя)
            /*int[,] matrix = {
                 { 1, 3, 4 },
                 { 2, 4, 6 },
                 {10, 8, 9 }
             };
             int rows = matrix.GetLength(0); // Кол-во строк
             int cols = matrix.GetLength(1); // Кол-во столбцов
             int max = matrix[0, 0], min = matrix[0, 0];
             for (int i=0;i < rows;i++)
             {
                 for (int j=0;j < cols;j++)
                 {
                     if (matrix[i, j] > max)                    
                         max = matrix[i, j];
                     if (matrix[i, j] < min)
                         min = matrix[i, j];
                 }
             }
             Console.Write("Максимальный элемент = ");
             Console.WriteLine(max);
             Console.Write("Минимальный элемент = ");
             Console.WriteLine(min);*/

            // Строки, как в C++            
            /*string str = "adfjaslkfjd";            
            char[] a = str.ToCharArray(); // Перевод строки в массив char*/

            // Задача - Подсчёт кол-ва слов в предложении
            /*string str = Console.ReadLine();
            string[] words = str.Split(" ");
            Console.WriteLine(words.Length);*/

            // Задача - Переворот слов
            /* string str = Console.ReadLine();
             string[] words = str.Split(" ");
             foreach (var el in words)
             {                
                 for (int i = el.Length - 1; i >= 0; i--)
                     Console.Write(el[i]);                 
                  Console.Write(' ');                
             }*/
            // Способы форматирования строк
            // 1. Интерполяция - внутрь строки засовывать переменные
            int num = 18;
            string str2 = $"цена: {num}";
            // 2. string.Format (очень древний способ)
            string str3 = String.Format("sadhklfhdsaklj {0}, {1}", num, str2);
            // 3. Concat
            string str4 = String.Concat("fsafdsa", num);
            // 4. Сложение строк
            string str5 = str4 + str3;
        }
        // enum
        enum En { el1 = 1, el2 = 2, el3 = 3 }; // Живут в классах, не в методах
    }
}
