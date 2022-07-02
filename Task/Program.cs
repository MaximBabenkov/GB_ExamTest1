/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа */

string[]CreateArrStr(int count)
{
    return new string[count];
}

void FillArrStr(string[]str)
{
    for (int i=0;i<str.Length;i++)
    {
        str[i]=Console.ReadLine()??"0";
    }   
}

void PrintArrStr(string[]arr)
{
    for (int i=0;i<arr.Length;i++)
    Console.Write($"{arr[i]} ");
}

