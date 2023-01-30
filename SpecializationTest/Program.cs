// контрольная для специализации
string[] array = {"Привет", "глашатай", "мех", "123", "7", "Да", "блоха", "уж", "!"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        count++;
    }
}
string[] arr = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        arr[j] = array[i];
        j++;
    }
}
string result = string.Empty;
for (int i = 0; i < count; i++)
{
    result += $"{arr[i]} ";
}
Console.WriteLine(result);