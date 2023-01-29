Console.WriteLine("Введите элементы массива через пробел");
string [] firstArray = Console.ReadLine().Split(" ");
string [] secondArray = new string[firstArray.Length];
for (int i = 0; i < firstArray.Length; i++)
{
    string element = firstArray[i];
    if (element.Length < 4)
    {
        secondArray[i] = element;
    }
}
secondArray = secondArray.Where(x => x != null).ToArray();
Console.WriteLine(String.Join("; ", secondArray));


