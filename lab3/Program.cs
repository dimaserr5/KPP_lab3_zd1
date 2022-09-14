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

                    if(N2 == 7)
                    {
                        Console.WriteLine("1. Оканчивается ли данное целое число цифрой 7: Да");
                    }else
                    {
                        Console.WriteLine("1. Оканчивается ли данное целое число цифрой 7: Да");
                    }

                    if(N1 > N2)
                    {
                        Console.WriteLine("2.Какая из цифр двухзначного числа больше: первая или вторая: Первая");
                    }else
                    {
                        Console.WriteLine("2.Какая из цифр двухзначного числа больше: первая или вторая: Вторая");
                    }

                    if(N1 == N2)
                    {
                        Console.WriteLine("3. Одинаковы ли цифры данного двухзначного числа: Да");
                    }else
                    {
                        Console.WriteLine("3. Одинаковы ли цифры данного двухзначного числа: Нет");
                    }

                    int chislo2_temp = N1 + N2;

                    if(chislo2_temp % 2 == 0)
                    {
                        Console.WriteLine("4. Является ли сумма цифр двухзначного числа четной: Да");
                        Console.WriteLine("5. Является ли сумма цифр двухзначного числа нечетной: Нет");
                    }else
                    {
                        Console.WriteLine("4. Является ли сумма цифр двухзначного числа четной: Нет");
                        Console.WriteLine("5. Является ли сумма цифр двухзначного числа нечетной: Да");
                    }

                    if (chislo2_temp % 3 == 0)
                    {
                        Console.WriteLine("6. Кратна ли трем сумма цифр двухзначного числа: Да");
                    } else
                    {
                        Console.WriteLine("6. Кратна ли трем сумма цифр двухзначного числа: Нет");
                    }

                    int a_number = 5;
                    
                    if (chislo2_temp % a_number == 0)
                    {
                        Console.WriteLine("7. Кратна ли числу A сумма цифр двухзначного числа: Да");
                    } else
                    {
                        Console.WriteLine("7. Кратна ли числу A сумма цифр двухзначного числа: Нет");
                    }

                    if (N1 > N2)
                    {
                        Console.WriteLine("8. Какая из цифр двухзначного числа больше: Первая");
                    }else
                    {
                        Console.WriteLine("8. Какая из цифр двухзначного числа больше: Вторая");
                    }








                }
                break;

            case "3":
                Console.WriteLine("3");

                Console.WriteLine("Выбрана задача 'Трехзначное' - Введите трехзначное число");
                int chislo3 = Convert.ToInt32(Console.ReadLine());

                if (chislo3 < 100 || chislo3 > 999)
                {
                    Console.WriteLine("Ошибка, число должно быть больше 100 И меньше 1000");
                }
                else
                {

                    string y1 = Convert.ToString(chislo3);
                    string n1 = y1.Remove(1, 2);
                    int N1 = Convert.ToInt32(n1); // выводит первое число



                    /*string y2 = Convert.ToString(chislo3);
                    string n2 = y2.Remove(2, 1);
                    int N2 = Convert.ToInt32(n2);

                    Console.WriteLine(N2);*/

                }
                break;

            case "4":
                Console.WriteLine("3");
            break;


            default:
                Console.WriteLine("Ошибка задачи");
            break;
            

        }
            

    }
}