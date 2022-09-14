using System;
internal class KPP_lab3_zd1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Выберите приложение:");
        Console.WriteLine("1 - Однозначное");
        Console.WriteLine("2 - ДвухЗначное");
        Console.WriteLine("3 - Трёхзначное");
        Console.WriteLine("4 - Треугольник");

        string zadacha = Console.ReadLine();

        switch (zadacha) {

            case "1":
                Console.WriteLine("1");
            break;

            case "2":
                Console.WriteLine("2");
            break;

            case "3":
                Console.WriteLine("3");
            break;

            case "4":
                Console.WriteLine("4");
            break;


            default:
                Console.WriteLine("Ошибка задачи");
            break;
            

        }
            

    }
}