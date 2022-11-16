static string SpaceRemove(string word)
{
    string newword = "";

    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] != ' ')
        {
            newword += word[i];
        }
    }
    return newword;
}

string word = Console.ReadLine().ToLower();

Console.WriteLine(SpaceRemove(word));