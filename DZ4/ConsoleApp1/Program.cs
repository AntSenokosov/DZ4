using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Введите количество элементов массива: ");

            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            mas = InitMas(mas);

            Console.WriteLine("Чётные значения:");

            char[] firstmas = FirstMas(mas, letters);

            for (int i = 0; i < firstmas.Length; i++)
            {
                firstmas[i] = UpperLetter(firstmas[i]);
            }

            PrintMas(firstmas);

            Console.WriteLine("Нечетные значения:");

            char[] secondmas = SecondMas(mas, letters);

            for (int i = 0; i < secondmas.Length; i++)
            {
                secondmas[i] = UpperLetter(secondmas[i]);
            }

            PrintMas(secondmas);

            Console.WriteLine();
            Console.WriteLine(CountUpperLetter(firstmas) > CountUpperLetter(secondmas) ? ("В массиве чётных значений больше в верхнем регистре букв:" + CountUpperLetter(firstmas)) : ("В массиве нечётных значений больше в верхнем регистре букв: " + CountUpperLetter(secondmas)));

            Console.ReadKey();
        }

        static void PrintMas(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        static int[] InitMas(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 27);
            }

            return arr;
        }

        static char[] FirstMas(int[] arr, char[] let)
        {
            int[] matr = new int[] { };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Array.Resize(ref matr, count + 1);
                    matr[count] = arr[i];
                    count++;
                }
            }

            char[] letmatr = new char[matr.Length];

            for (int i = 0; i < matr.Length; i++)
            {
                for (int j = 0; j < let.Length; j++)
                {
                    if (matr[i] == j)
                    {
                        letmatr[i] = let[j];
                    }
                }
            }

            return letmatr;
        }

        static char[] SecondMas(int[] arr, char[] let)
        {
            int[] matr = new int[] { };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    Array.Resize(ref matr, count + 1);
                    matr[count] = arr[i];
                    count++;
                }
            }

            char[] letmatr = new char[matr.Length];
            for (int i = 0; i < matr.Length; i++)
            {
                for (int j = 0; j < let.Length; j++)
                {
                    if (matr[i] == j)
                    {
                        letmatr[i] = let[j];
                    }
                }
            }

            return letmatr;
        }

        static char UpperLetter(char letter)
        {
            char[] let = { 'a', 'e', 'i', 'd', 'h', 'j' };

            foreach (char item in let)
            {
                if (letter == item)
                {
                    letter = char.ToUpper(letter);
                }
            }

            return letter;
        }

        static int CountUpperLetter(char[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
