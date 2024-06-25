using System;

int max_X = 12;
int min_X = -12;


Console.WriteLine("Введите координату x:");
string inputX = Console.ReadLine();
int point_X = Convert.ToInt32(inputX);

Console.WriteLine("Введите координату y:");
string inputY = Console.ReadLine();
int point_Y = Convert.ToInt32(inputY);

Console.WriteLine($"Вы ввели точку с координатами ({point_X}, {point_Y})");


int limit_Y;

switch (point_X, point_Y)
{
    case ( > 0, > 0):
        Console.WriteLine("Точка находится в первой четверти");

        //берём координату X и высчитываем для неё макс. допустимую Y.
        //Если current_Y < limit_Y, то точка (point) находится внутри диагонали, если число превосходит limit_Y - то точка вне диагонали.
        limit_Y = max_X - point_X;

        Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");

        if (point_X<= max_X && point_Y <= limit_Y){Console.WriteLine($"Точка находится под диагональю. (Область N1)");}
        else { Console.WriteLine($"Точка находится вне диагонали (Область N4)"); }

        break;
    case ( < 0, > 0):
        Console.WriteLine("Точка находится во второй четверти");

        limit_Y = Math.Abs (min_X + Math.Abs(point_X));

        Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");
        if (point_X >= min_X && point_Y <= limit_Y) { Console.WriteLine($"Точка находится под диагональю (Область N2)"); }
        else { Console.WriteLine($"Точка находится вне диагонали (Область N3)"); }

        break;
    case ( < 0, < 0):
        Console.WriteLine("Точка находится в третьей четверти");
        limit_Y = min_X - point_X;

        Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");
        if (point_X >= min_X && point_Y >= limit_Y) { Console.WriteLine($"Точка находится под диагональю (Область N1)."); }
        else { Console.WriteLine($"Точка находится вне диагонали (Область (N3)."); }

        break;
    case ( > 0, < 0):
        Console.WriteLine("Точка находится в четвёртой четверти");
        limit_Y = min_X + Math.Abs(point_X);

        Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");
        if (point_X <= max_X && point_Y <= limit_Y) { Console.WriteLine($"Точка находится под диагональю (Область N2).");  }
        else { Console.WriteLine($"Точка находится вне диагонали (Область (N4)."); }

        break;
}

// Диагональ 1й четверти от X:12 до Y:12
// Диагональ 2й четверти от X:-12 до Y:12
// Диагональ 3й четверти от X:-12 до Y:-12
// Диагональ 4й четверти от X:12 до Y:12
