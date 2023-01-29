Console.WriteLine("Введите элементы массива через пробел");
string [] firstArray = Console.ReadLine().Split(" ");
string [] secondArray = new string[10];
for (int i = 0; i < firstArray.Length; i++)
{
        string element = firstArray[i];
    if (element.Length < 4)
    {
        secondArray[i] = element;
    }
}
Console.WriteLine(String.Join("; ", secondArray));


