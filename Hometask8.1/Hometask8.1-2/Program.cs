// 2. Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

int[,] numbers =
{
    {5, 19, 4, 2},
    {16, 15, 7, 9},
    {12, 1, 3, 18},
    {8, 14, 6, 20 },
    {13, 10, 17, 11}
};
int height = numbers.GetLength(0);
int length = numbers.GetLength(1);

Console.WriteLine("Original array:"); // output
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < length; j++)
    {
        Console.Write($"{numbers[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int k = 0; k < height * length; k++) // sorting
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length - 1; j++)
        {
            if (numbers[i, j] > numbers[i, j + 1])
            {
                var temp = numbers[i, j];
                numbers[i, j] = numbers[i, j + 1];
                numbers[i, j + 1] = temp;
            }
        }
        if ((i < height - 1) && (numbers[i, length - 1] > numbers[i + 1, 0]))
        {
            var temp = numbers[i, length - 1];
            numbers[i, length - 1] = numbers[i + 1, 0];
            numbers[i + 1, 0] = temp;
        }
    }
}
Console.WriteLine("Sorted array:"); // output
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < length; j++)
    {
        Console.Write($"{numbers[i, j]}\t");
    }
    Console.WriteLine();
}