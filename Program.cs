string[] str = { "Hello", "2", "world", ":-)" };
string[] newStr = NewArray(str);
string firstArray = PrintArray(str);
string secondArray = PrintArray(newStr);
Console.WriteLine(firstArray + " -> " + secondArray);


int СountingСharsGivenSize(string[] str)
{
    int count = 0;
    foreach (string item in str)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] str)
{
    int strLength = СountingСharsGivenSize(str);
    string[] newStr = new string[strLength];
    int i = 0;
    foreach (string item in str)
    {
        if (item.Length <= 3)
        {
            newStr[i] = item;
            i++;
        }
    }
    return newStr;
}

string PrintArray(string[] str)
{
    string stringArray = "[";
    for (int i = 0; i < str.Length; i++)
    {
        if (i == str.Length - 1)
        {
            stringArray += $"\"{str[i]}\"";
            break;
        }
        stringArray += ($"\"{str[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}