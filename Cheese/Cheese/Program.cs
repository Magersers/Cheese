﻿using System;
using System.IO;

namespace Cheese
{
    class MilkFarm
    {
        static void Main(string[] args)
        {
            int n=0,m=0;
            Console.Write("Введите кол-во элементов в массиве = ");
            for (; n <= 0;)
            {
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Ошибка ввода! Введитее ещё раз = ");
                }
                if (n < 0)
                {
                    Console.WriteLine("Значение должно быть больше 0!");
                }
            }
            object[] Products = new object[n * 3];
            Cheese sir = new Cheese();
            for(int i=0; i<n; i++)
            {
                Console.Write("Введите марку сыра = ");
                sir.marka = Console.ReadLine();
                Products[m] = sir.marka; m++;
                Console.Write("Введите производителя сыра = ");
                sir.proizvoditel = Console.ReadLine();
                Products[m] = sir.proizvoditel; m++;
                Console.Write("Введите Процент жира = ");
                while (!int.TryParse(Console.ReadLine(), out sir.prozentChira))
                {
                    Console.Write("Ошибка ввода! Введитее правильный тип данных = ");
                }
                Products[m] = sir.prozentChira;

                m++;
            }
            StreamWriter sirr = new StreamWriter("sir.txt");
            m = 0;
                for (int i = 0; i<n; i++)
            {
                sirr.WriteLine("");
                sirr.WriteLine("Марка сыра: " + Products[m]); m++;
                sirr.WriteLine("Производитель сыра: " + Products[m]); m++;
                sirr.WriteLine("Процент жира: " + Products[m]); m++;
            }
            sirr.Close();
        }
    }
    struct Cheese
    {
        public string marka, proizvoditel;
        public int prozentChira;
    }
}
