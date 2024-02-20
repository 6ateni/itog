string[] str = { "Hello", "2", "world", ":-)" };
string[] newStr = NewArray(str);


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