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
                Console.WriteLine("Выбрана задача 'Однозначное' - Введите однозначное число");
                int chislo1 = Convert.ToInt32(Console.ReadLine());
                if (chislo1 > 10 || chislo1 < 2) {
                    Console.WriteLine("Ошибка, число должно быть больше 2 И меньше 10");
                }else
                {
                    if (chislo1 % 2 == 0)
                    {
                        Console.WriteLine("Число: " + chislo1 + " чётное");
                    }
                    else
                    {
                        Console.WriteLine("Число: " + chislo1 + " не чётное");
                    }
                }
            break;

            case "2":
                Console.WriteLine("Выбрана задача 'ДвухЗначное' - Введите двухзначное число");
                int chislo2 = Convert.ToInt32(Console.ReadLine());
                if(chislo2 < 10 || chislo2 > 99)
                {
                    Console.WriteLine("Ошибка, число должно быть больше 9 И меньше 100");
                }else
                {
                    string y1 = Convert.ToString(chislo2);
                    string n1 = y1.Remove(1,1);
                    int N1 = Convert.ToInt32(n1);

                    string y2 = Convert.ToString(chislo2);
                    string n2 = y1.Remove(0, 1);
                    int N2 = Convert.ToInt32(n2);

                    Console.WriteLine("Первое число: " + N1 + " Второе число: " + N2);


                }
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