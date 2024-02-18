using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
namespace Lab2CSharp;


internal class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++) Console.Write(a[i]+ " ");
        Console.WriteLine();
    }
    static int[] Create()
    {
        Console.WriteLine("Розмірність масиву: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }
    static void task1()
    {
        int[] a;
        a = Create();
        Print(a);
        for(int i=0;i<a.Length; i++)
        {
            if (a[i] % 7 != 0)
            {
                Console.Write(a[i] + " ");
            }
        }
        Console.WriteLine("Розмірність масиву: [n,m]");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] b = new int[n, m];
        for(int i=0;i<n;i++)
        {
            for(int j=-;j<m;j++)
            {
                if (b[i,j] % 7 != 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
    static void task2()
    {
        int[] a;
        a = Create();
        Print(a);
        int min = a[0];
        for(int i = 0;i<a.Length;i++)
        {
            if (a[i] < min) min = a[i];
        }
        Console.WriteLine("Min element - " + min);
    }
    static void task3()
    {
        Console.Write("Введіть розмірність n для двовимірного масиву (n x n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        // Зчитуємо елементи масиву з консолі
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Введіть елемент [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Введений масив:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        bool flag = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    flag = false;
                }
            }
        }
        Console.WriteLine("Масив симетричний - " +  flag);
    }
    static void task4()
    {
        // Отримати розмірність масиву від користувача
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість елементів у кожному рядку (m): ");
        int m = int.Parse(Console.ReadLine());

        // Ініціалізація та введення масиву
        int[,] array = new int[n, m];
        Console.WriteLine("Введіть елементи масиву:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
    }
        int[] vector = new int[n];

        // Введення елементів вектора
        Console.WriteLine("Введіть елементи вектора:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

            // Заміна парних стовпців на вектор X
        for (int i = 0; i < n; i ++)
        {
            for (int j = 1; j < m; j += 2) // Починаючи з другого стовпця, з кроком 2
            {
                array[i, j] = vector[i]; // Заміна на значення вектора X
            }
        }

        // Вивід зміненого масиву
        Console.WriteLine("Змінений масив:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
static void Main(string[] args)
    {
        Console.WriteLine("Lab 2 CSharp");
        while (true)
        {
            Console.WriteLine("Введiть номер завдання:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                default:
                    Console.WriteLine("Не вiрно");
                    break;
            }
        }
    }
}
