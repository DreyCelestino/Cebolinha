Console.Clear();

String frase;

Console.WriteLine("Digite algo pro Cebolinha repetir!: ");
frase = Console.ReadLine().Replace("r", "l");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Cebolinha: {frase}");

Console.ResetColor();