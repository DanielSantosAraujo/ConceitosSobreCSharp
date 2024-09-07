namespace Modulo11;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2024, 09, 07, 10, 24, 30);
        var date2 = DateTime.Parse("2024/09/07 10:24:30");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));

        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);

        // DateTimeOffset.UtcNow
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2024-01-01");

        //var diff = date1 - date2;

        var diff = date1.Subtract(date2);

        Console.WriteLine(diff.TotalDays);
        Console.WriteLine(diff.TotalHours);

    }

    public void AulaAddDiasMesAno()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddDays(3));
        Console.WriteLine(date1.AddMonths(150));
        Console.WriteLine(date1.AddYears(300));

    }

    public void AulaAddHorasMinutosSegundos()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddHours(3));
        Console.WriteLine(date1.AddMinutes(150));
        Console.WriteLine(date1.AddSeconds(300));

    }

    public void AulaDiaDaSemana()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.DayOfWeek);

    }

    //Trabalha apenas com data
    public void AulaDateOnly()
    {
        //var somenteData = new DateOnly(2024,09,07);
        var somenteData = DateOnly.Parse("2024-09-07");

        Console.WriteLine(somenteData);

    }

    //Trabalha apenas com hora
    public void AulaTimeOnly()
    {
        
        var somenteHora = TimeOnly.Parse("10:00:30");

        Console.WriteLine(somenteHora.ToString("hh:mm:ss"));

    }
}