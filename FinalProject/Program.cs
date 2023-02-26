string[] array1 = new string[9] { "a", "bb", "ccc", "dddd", "eeeeee", "ffffff", "x", "vvv", "zz" };
string[] array2 = new string[array1.Length];
void FormedArray(string[] array1, string[] array2)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[count] = array1[i];
      count++;
    }
  }
}
void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
PrintArray(array1);
FormedArray(array1, array2);
PrintArray(array2);