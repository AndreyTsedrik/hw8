int a = InputNumbers("Введите число строк 1-й матрицы: ");
int b = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int c = InputNumbers("Введите число столбцов 2-й матрицы: ");
int langth = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[a, b];
CreateArray(firstMartrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[b, c];
CreateArray(secomdMartrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[a,c];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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