string[] str = { "Hello", "2", "world", ":-)" };


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

