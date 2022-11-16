// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 

void Print (string[] array)
{
    for (int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
}

string[] array = {"1234","567","-2","computer science"};

int count=0;
for (int i=0;i<array.Length; i++)
{
    if (array[i].Length<=3)
    {
        count++;
    }
}

string[]array2=new string[count];
int j=0;
for (int i=0;i<array.Length; i++)
{
    if (array[i].Length<=3)
    {
        array2[j]=array[i];
        j++;
    }
}

Print(array);
Console.WriteLine();
Print(array2);
