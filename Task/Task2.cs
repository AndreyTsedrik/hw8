Console.WriteLine("Введите a, b и длинну массива:");
int a = InputNumbers("Введите a: ");
int b = InputNumbers("Введите b: ");
int langth = InputNumbers("Введите длинну массива: ");

int[,] array = new int[a, b];
CreateArray(array);
PrintArray(array);
Console.WriteLine("");

int minSum = 0;
int Sum = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int SumLine = SumLineElements(array, i);
  if (Sum > SumLine)
  {
    Sum = SumLine;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(langth);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}