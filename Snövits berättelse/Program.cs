Console.ForegroundColor = ConsoleColor.DarkCyan;

string choice = "";

Console.WriteLine("Du är i Skogen och hör en gren knäckas");
Console.WriteLine("Du hoppar till men kom ihåg att du är Skoogen och kan ta allt");
Console.WriteLine("Går du och investigerar. Ja eller nej");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "ja")
{
    Console.WriteLine("Du går längre in i skogen och ser en skum grabb hålla på att bita på en pinne");
    Console.WriteLine("Du börjar fundera över alla val du gjort i ditt liv för att sluta upp här");
    Console.WriteLine("Du ser han sedan vända sig mot dig och börja naffsa på ett löv");
    Console.WriteLine("Du minns att du pungade en kyckling");
    Console.WriteLine("Du slänger kycklingen och mannen springer efter den");
    Console.WriteLine("Du börjar sedan naffsa på samma pinne som den skumma mannen");
}
else if (choice == "nej")
{
    Console.WriteLine("Du går tillbaka till tältet och börjar göra 4 kebabrullar");
    Console.WriteLine("Du tröck i dig alla 4 och sedan klunkade du en tröcca");
    Console.WriteLine("Du blev trött");
    Console.WriteLine("Går du och lägger dig i tältet eller går du hem ?");

    choice = Console.ReadLine();
    choice = choice.ToLower();

    if (choice == "hem")
    {
        Console.WriteLine("Du går hem och gibbar en CS comp med bojsen");
        Console.WriteLine("Du förlorar och blir lack. Du hamnar sedan i finkan för illegla hot");
    }
    else if (choice == "tältet")
    {
        Console.WriteLine("Du går och lägger dig i tältet och försöker sova");
        Console.WriteLine("Du fick abstinens attack och dog. (Borde gibbat CS)");
    }
    else
    {
        Console.WriteLine("Du fick en stroke och dog. Lär dig svara på frågor rätt");
    }
}
else
{
    Console.WriteLine("Du fick en hjärtattack, för du är för dum ihuvudet för att svara rätt");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();