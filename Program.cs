int n = 1;

Console.ForegroundColor= ConsoleColor.DarkRed;
System.Console.WriteLine("----UmDoisTresPim----");
System.Console.WriteLine();
Console.ResetColor();

for (n = 1; n <= 40; n++)

if (n % 4 == 0)
{
    Console.ForegroundColor= ConsoleColor.Green;
    System.Console.Write(" pim\n");
    Console.ResetColor();
}

else
{
    Console.ForegroundColor= ConsoleColor.White;
    System.Console.Write($"{n,2} ");
    Console.ResetColor();
}