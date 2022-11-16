string text = "Believing neglected so so allowance existence departure in".ToLower();

WriteTextToAB(text);


static void WriteTextToAB(string text)
{
    Console.Write(text[0]);

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == ' ')
        {
            Console.Write(" " + text[i + 1] + " ");
        }
    }
}

