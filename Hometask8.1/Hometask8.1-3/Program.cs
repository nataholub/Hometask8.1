// 3. Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

int[] numbers = new int[10];

Random rnd = new Random();

int length = numbers.Length;

for (int i = 0; i < length; i++)
{
    numbers[i] = rnd.Next(100);
    Console.Write($"{numbers[i]}\t");
}
int[] numbers2 = new int[length - 1];

Console.Write($"\n\nEnter the index of element which will be deleted (from 0 to {length - 1}): ");

int index;

bool isParsed = int.TryParse(Console.ReadLine(), out index);
Console.WriteLine();

if (isParsed && index < length && index >=0)
{
    int j = 0;

    for (int i = 0; i < length; i++)
    {
        if (i != index)
        {
            numbers2[j] = numbers[i];
            j++;
        }
    }
    foreach (int number in numbers2)
        Console.Write($"{number}\t");
}
else
    Console.WriteLine("Invalid input");
