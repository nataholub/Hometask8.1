// 4. Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

Random rnd = new Random();
int[,] numbers = new int[5, 5];
int length = numbers.GetLength(0);

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        numbers[i, j] = rnd.Next(10);
        Console.Write($"{numbers[i, j]}\t");
    }
    Console.WriteLine();
}
int sumDiagonal1 = 0;
int sumDiagonal2 = 0;

for (int i = 0; i < length; i++)
{    
    sumDiagonal1 += numbers[i, i];
    sumDiagonal2 += numbers[i, length - 1 - i];
}
Console.WriteLine($"\nThe sum of the main diagonal elements is {sumDiagonal1}");
Console.WriteLine($"\nThe sum of the secondary diagonal elements is {sumDiagonal2}");