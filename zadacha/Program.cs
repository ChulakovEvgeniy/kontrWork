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

int CountElliment(string[] stringArray)
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



Console.Clear();
int count = InNumber("Введите количество элементов массива:");
string[] strArray = new string[count];
FillStringArray(strArray);
int newCount = CountElliment(strArray);
string[] rezult = NewString(strArray, newCount);
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(",", strArray)}]");
System.Console.WriteLine();
System.Console.WriteLine($"Новый массив из строк, длина которых не более 3 символов: [{String.Join(",", rezult)}]");

