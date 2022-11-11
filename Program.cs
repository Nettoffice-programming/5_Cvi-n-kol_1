using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvořte tři pole o 5 unikátních prvcích. První pole naplňte pomocí console.
            int[] arr1 = new int[5];
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int[] arr3 = { 6, 7, 8, 9, 10 };

            int value;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter value for first array at index {i}: ");
                value = int.Parse(Console.ReadLine());
                arr1[i] = value;
            }

            //Vypište všechny prvky prvního pole. Výpis bude vždy na nový řádek
            //a bude doprovázen větou "Hodnota X na indexu Y v prvním poli je: "
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Value in first array at index {i} is {arr1[i]}");
            }

            //Sečtěte všechny prvky druhého pole
            Console.ReadKey();
            Console.Clear();

            int sum = 0;
            Array.ForEach(arr2, delegate (int i)
            {
                sum += i;
            });
            Console.WriteLine($"All summed values in second array is: {sum}");

            //Prohoďte prvky třetího pole o jednu pozici.
            //První hodnota bude tudíž po transformaci druhá, druhá třetí, třetí čtvrtá, čtvrtá pátá a pátá první
            Console.ReadKey();
            Console.Clear();

            int[] arrPom = { arr3[0], arr3[1], arr3[2], arr3[3], arr3[4] };
            int index = 0;
            while (index <= 4)
            {
                if (index == 4)
                    arr3[4] = arrPom[0];
                else
                    arr3[index] = arrPom[index + 1];

                index++;
            }
        }
    }
}
