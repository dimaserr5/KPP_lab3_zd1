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
                Console.WriteLine("Выбрана задача 'Отнозначное' - Введите однозначное число");
                int chislo = Convert.ToInt32(Console.ReadLine());
                if (chislo > 9 || chislo < 0) {
                    Console.WriteLine("Ошибка, число должно быть больше -1 И меньше 10");
                }else
                {
                    
                }
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