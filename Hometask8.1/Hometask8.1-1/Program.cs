// 1. Написати програму, що знаходить другий найбільший елемент масиву.

int[] numbers = new int[10];

Random rnd = new Random();

int length = numbers.Length;

for (int i = 0; i < length; i++)
{
    numbers[i] = rnd.Next(-100, 100);
    Console.Write($"{numbers[i]}\t");
}
int maxNumber = int.MinValue;
int secondMaxNumber = int.MinValue;

    for (int i = 0; i < length; i++)
    {
        if (numbers[i] > maxNumber)
        {
            secondMaxNumber = maxNumber;
            maxNumber = numbers[i];
        }
        else if (numbers[i] < maxNumber && numbers[i] > secondMaxNumber)
            secondMaxNumber = numbers[i];
    }
Console.WriteLine($"\n\nThe second maximum element of the array is {secondMaxNumber}");