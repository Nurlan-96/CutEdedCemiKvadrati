Console.WriteLine(count(10, 11, 12, 13, 14, 15, 16, 17));
int count(params int[] a)
{
    int res = 0;
    foreach (int i in a)
    {
        if (i % 2 == 0)
        {
            res += i;
        }
    }
    return res*=res;
}