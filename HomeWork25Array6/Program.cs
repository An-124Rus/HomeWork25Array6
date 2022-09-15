using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 10;

        Console.Write("Введите длину массива: ");
        int arrayLegth = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[arrayLegth];

        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue);

            Console.Write(array[i] + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < arrayLegth - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    int temporaryNumber = array[i];
                    array[i] = array[j];
                    array[j] = temporaryNumber;
                }
            }
        }

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
}