

Console.WriteLine("Ведіть два слова:");
string name1 = Console.ReadLine();
string name2 = Console.ReadLine();
Console.WriteLine($"Довжина першого слова {LengthName()}");
Console.WriteLine(SameName() ? "Слова рiвнi" : "Слова не рi");
Console.Write(SortName());
//Console.WriteLine( SameLetters());

int LengthName()
{ return name1.Length; }

string SortName()
{
    var sort2 = string.Join(",", name1.OrderBy(p => p));

    return sort2;
}
bool SameName()
{
    bool result = name1.Equals(name2);
    {
        return result;
    }
}

void SameLetters()
{
    var chars1 = name1.ToCharArray();
    var chars2 = name2.ToCharArray();
    for (int i = 0; i < chars1.Length-1; i++)
    {
       char tp = '1';
        for (int j = 0; j < chars2.Length; j++)
            if (chars1[i] == chars2[j])
            {
                 var temp = chars2[tp];
                chars2[tp] = chars1[i];
                chars1[i] = temp;
               
            } // Написав код, але не знаю чи він правильний бо не знаю як його вивести на друк
        
    }
    
}
