int InNumber(string nameSpace)
{
    System.Console.Write(nameSpace);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FillStringArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}

int Count(string[] stringArray)
{
    int countElliment = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            countElliment++;
        }
    }
    return countElliment;
}

string[] NewString(string[] stringArray,int count)
{
    string[] finish = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            finish[j] = stringArray[i];
            j++;
        }
    }
    return finish;
}

void PrintArray(string[] stringArray)
{
    Console.Write("{");
     for (int i = 0;i<stringArray.Length;i++)
    {
        if (i<stringArray.Length-1)
        {
            Console.Write($"{stringArray[i]}, ");
        }
        else Console.Write($"{stringArray[i]}");
    }
    Console.Write("}");
}
//string[] str = new string [4] {"Hello", "2", "world", ":-)"};


Console.Clear();
int count = InNumber("Введите количество элементов массива:");
string[] strArray = new string[count];
FillStringArray(strArray);
int newCount = Count(strArray);
string[] rezult = NewString(strArray, newCount);
PrintArray(rezult);

