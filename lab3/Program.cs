using System;
internal class KPP_lab3_zd1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Выберите приложение:");
        Console.WriteLine("1 - Однозначное");
        Console.WriteLine("2 - Двухзначное");
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
                    Console.ReadKey();
                }
            break;
                
            case "2":
                Console.WriteLine("Выбрана задача 'Двухзначное' - Введите двухзначное число");
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
                        Console.WriteLine("1. Оканчивается ли данное целое число цифрой 7: Нет");
                    }

                    if(N1 > N2)
                    {
                        Console.WriteLine("2. Какая из цифр двухзначного числа больше: первая или вторая: Первая");
                    }else
                    {
                        Console.WriteLine("2. Какая из цифр двухзначного числа больше: первая или вторая: Вторая");
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

                    Console.ReadKey();






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
                    

                    string y2 = Convert.ToString(chislo3);
                    string a2 = y2.Remove(2, 1);
                    string n2 = a2.Remove(0, 1);
                    int N2 = Convert.ToInt32(n2);
                    

                    string y3 = Convert.ToString(chislo3);
                    string n3 = y3.Remove(0, 2);
                    int N3 = Convert.ToInt32(n3);


                    if(N1 > N3)
                    {
                        Console.WriteLine("1. Какая из цифр трехзначного числа больше? Первая или Последняя: Первая.");
                    }else if(N1 < N3)
                    {
                        Console.WriteLine("1. Какая из цифр трехзначного числа больше? Первая или Последняя: Последняя.");
                    }else
                    {
                        Console.WriteLine("1. Какая из цифр трехзначного числа больше? Первая или Последняя: Они равны.");
                    }
                    
                    if(N1 > N2)
                    {
                        Console.WriteLine("2. Какая из цифр трехзначного числа больше? Первая или Вторая: Первая.");
                    }else if(N1 < N2) 
                    {
                         Console.WriteLine("2. Какая из цифр трехзначного числа больше? Первая или Вторая: Вторая.");
                    }else
                    {
                        Console.WriteLine("2. Какая из цифр трехзначного числа больше? Первая или Вторая: Они равны.");
                    }

                    if(N2 > N3)
                    {
                        Console.WriteLine("3. Какая из цифр трехзначного числа больше? Вторая или Последняя: Вторая.");
                    }else if(N2 < N3)
                    {
                        Console.WriteLine("3. Какая из цифр трехзначного числа больше? Вторая или Последняя: Последняя.");
                    }else
                    {
                        Console.WriteLine("3. Какая из цифр трехзначного числа больше? Вторая или Последняя: Они равны.");
                    }

                    if((N1 == N2) && (N1 == N3))
                    {
                        Console.WriteLine("4. Все ли цифры трехзначного числа одинаковые: Да.");
                    } else
                    {
                        Console.WriteLine("4. Все ли цифры трехзначного числа одинаковые: Нет.");
                    }

                    Console.ReadKey();

                    

                }
                break;

            case "4":
                Console.WriteLine("4");

                Console.WriteLine("Введите сторону A");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сторону B");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сторону C");
                int C = Convert.ToInt32(Console.ReadLine());

                if ((A + B) < C)
                {
                    int Error = 1;
                }else if ((A + C) < B)
                {
                    int Error = 1;
                }else if ((B + C) < A)
                {
                    int Error = 1;
                }

                if (pi.Error)
                {
                    Console.WriteLine("1. Существует ли треугольник с длинами сторон a, b, c: Нет.");
                }else
                    Console.WriteLine("1. Существует ли треугольник с длинами сторон a, b, c: Нет.");
                }
                else if ((A + C) < B)
                {
                    Console.WriteLine("1. Существует ли треугольник с длинами сторон a, b, c: Нет.");
                }
                else if ((B + C) < A)
                {
                    Console.WriteLine("1. Существует ли треугольник с длинами сторон a, b, c: Нет.");
                }
                else
                {
                    Console.WriteLine("1. Существует ли треугольник с длинами сторон a, b, c: Да.");
                }



                Console.ReadKey();
            break;
                if (A * A + B * B == C * C)
                {
                    Console.WriteLine("2. Является ли треугольник с длинами сторон a, b, c прямоугольным: Да");
                }else
                {
                    Console.WriteLine("2. Является ли треугольник с длинами сторон a, b, c прямоугольным: Нет");
                }

                    break;


            default:
                Console.WriteLine("Ошибка задачи");
            break;
            

        }
            

    }
}