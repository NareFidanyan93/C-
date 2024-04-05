// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void Main()
{
    int myarraySize = ReadInt("Введите размер массива: ");
    int[] myarray = GenerateArray(myarraySize, 1, 90);
    PrintArray(myarray);
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);

    return tempArray;

}
void PrintArray(int[] newArray, int i = newArray.Lenght-1)
{
    if (i < 0)
{
    return;
}
    Console.WriteLine(newArray[i]);
    PrintArray(newArray, i--);
}

Main();
