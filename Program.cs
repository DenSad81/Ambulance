using System;

class Program
{
    static void Main(string[] args) {
        int quantityPeople;
        int timePerHumanMinutes = 10;
        int minutesInHour = 60;
        int waitTotalTimeMinutes;
        int waitHours;
        int waitMinutes;

        Console.Write("Сколько пациентов перед вами: ");
        quantityPeople = Convert.ToInt32(Console.ReadLine());
        waitTotalTimeMinutes = quantityPeople * timePerHumanMinutes;
        waitHours = waitTotalTimeMinutes / minutesInHour;
        waitMinutes = waitTotalTimeMinutes - waitHours * minutesInHour;
        Console.WriteLine($"Вам стоять в очереди часов {waitHours}, минут {waitMinutes}");
    }
}
