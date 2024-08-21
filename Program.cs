using System;

namespace TaskJunior2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberRandom;
            int firstInput = 1;
            int finishInput = 101;
            int degreeValue = 1;
            int baseNumber = 2;

            Console.WriteLine("Приветствую вас в математическом МИРЕ.\n\n" +
                              "В котором мы будем находить минимальную степень двойки, превосходящую заданное число.\n");

            Console.WriteLine("Нажмите любую кнопку, чтобы создать случайное число.");
            Console.ReadKey();

            numberRandom = random.Next(firstInput, finishInput);

            Console.WriteLine($"\n{numberRandom}");

            while (baseNumber < numberRandom)
            {
                baseNumber *= degreeValue;
                degreeValue++;
            }

            Console.WriteLine($"Минимальная степень {baseNumber}, превышающая заданное число, равна {degreeValue}.");
        }
    }
}
