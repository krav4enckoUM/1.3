using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //Подключаем ГСЧ
            double[] mas = new double[10]; //Исходный массив
            double[] masCleared = new double[0]; //"Чищенный" массив
            double value = -1; //Переменная с максимальным текущим значением массива

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Math.Round(rnd.NextDouble() * 100, 2); //Заполняем массив случ. действительными числами от 0 до 100
                Console.Write("{0}   ", mas[i]);
            }

            Console.WriteLine("\nНовый массив:");
            foreach (var item in mas) //Работаем с каждым элементом массива
            {
                if (item >= value) //Если текущий элемент массива больше или равен предыдущего максимального значения
                {
                    value = item; //Переопределяем новое максимальное значение

                    Console.Write("{0}   ", item); //Выводим на экран
                }
            }
            Console.ReadKey();
        }
    }
}