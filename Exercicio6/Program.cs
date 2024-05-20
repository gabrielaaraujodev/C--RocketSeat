Console.WriteLine("Como você quer que a data seja apresentada\n1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)\n2 - Apenas a data no formato 01/03/2024\"\n3 - Apenas a hora no formato de 24 horas.\n4 - A data com o mês por extenso.");
int option = int.Parse(Console.ReadLine());

var anoDiaMes = DateTime.Now;


switch (option)
{
    case 1:
        var horario = DateTime.Now;
        Console.WriteLine($"{anoDiaMes.DayOfWeek}, {horario}");
        break;
    case 2:
        Console.WriteLine(anoDiaMes.ToString("dd/MM/yy"));
        break;
    case 3:
        var hora24h = DateTime.Now;
        Console.WriteLine(hora24h.ToString("HH:mm:ss"));
    break;
    case 4:
        var dataComMesPorExtenso = anoDiaMes.ToString("dd/MMMM/yy");
        Console.WriteLine(dataComMesPorExtenso);
    break;
}

