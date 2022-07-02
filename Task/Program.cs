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

int FindAmountStr(string[]array,int value)
{
int amount=0;
for(int index=0;index<array.Length;index++)
    if (array[index].Length<=value)
        amount++;
return amount;
}

void FillArrVal(string[]arrIn,string[]arrOut,int val)
{
int index=0;
int i=0;
while(index<arrIn.Length)
    if (arrIn[index].Length<=val)
    {
        arrOut[i]=arrIn[index];
        i++;
        index++;
        
    }
    else
    {
        index++;
    }
}

Console.Clear();
Console.WriteLine("Let's create your array of strings");
Console.Write("Enter your number of strings: ");
int lengthIn=int.Parse(Console.ReadLine()??"0");
string[]arrayIn=CreateArrStr(lengthIn);
Console.WriteLine("Enter your strings: ");
FillArrStr(arrayIn);
Console.Write($"Your array: ");
PrintArrStr(arrayIn);
Console.WriteLine();
Console.Write("Enter your number of symbols: ");
int numbSymb=int.Parse(Console.ReadLine()??"0");
int lengthOut=FindAmountStr(arrayIn,numbSymb);
if (lengthOut>0)
{
string[]arrayOut=CreateArrStr(lengthOut);
FillArrVal(arrayIn,arrayOut,numbSymb);
Console.Write($"New array: ");
PrintArrStr(arrayOut);    
}
