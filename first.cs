CountNum(5);

CountAndWrite(6);


static void CountNum(int num1)
{
    for (int i = 0; i < num1; i++)
    {
        if (i % 2 == 0)
        {
            WriteNum(i);
        }
    }
}

static void WriteNum(int num)
{
    Console.WriteLine(num);
}

static int CountAndWrite(int num1)
{
    for (int i = 0; i < num1; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }

    }
    return 0;
}



