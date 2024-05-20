Console.WriteLine("Informe uma ou mais palavras: ");
string word = Console.ReadLine();

word = word.Replace(" ", "");

Console.WriteLine($"A(s) Palavra(s) digita(s) possui(em): {word.Length} caracteres");