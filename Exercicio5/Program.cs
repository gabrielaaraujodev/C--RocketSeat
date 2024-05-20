static bool Verificacao (char[] newPlaca)
{
    for (int i = 0; i < newPlaca.Length - 4; i++)
    {
        if (!char.IsDigit(newPlaca[i]))
        {
            return false;
        }
    }

    for (int i = 3; i < newPlaca.Length; i++)
    {
        if (!char.IsLetter(newPlaca[i]))
        {
            return false;
        }
    }
    return true;
}



Console.WriteLine("Informe sua placa: ");
string placa = Console.ReadLine();

var newPlaca = placa.ToCharArray();

if(Verificacao(newPlaca))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}