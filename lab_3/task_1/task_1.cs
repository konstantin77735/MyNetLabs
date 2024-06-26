using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int max_X = 12;
int min_X = -12;


Console.WriteLine("Введите координату x:");
string inputX = Console.ReadLine();
int point_X = Convert.ToInt32(inputX);

Console.WriteLine("Введите координату y:");
string inputY = Console.ReadLine();
int point_Y = Convert.ToInt32(inputY);

Console.WriteLine($"Вы ввели точку с координатами ({point_X}, {point_Y})");


bool is_M_in_N1 = false;
bool is_M_in_N2 = false;
bool is_M_in_N3 = false;
bool is_M_in_N4 = false;

int limit_Y;

switch (point_X, point_Y)
{
    case ( > 0, > 0):
        Console.WriteLine("Точка находится в первой четверти");

        //берём координату X и высчитываем для неё макс. допустимую Y.
        //Если current_Y < limit_Y, то точка (point) находится внутри диагонали, если число превосходит limit_Y - то точка вне диагонали.
        limit_Y = max_X - point_X;

        //Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");


        //Задание: границы области относить к области с наибольшим номером.
        //Пояснение: границы всех областей: это диапазон от 0 до 12/-12 - по X и Y.
        //Поэтому граница принадлежит к той области, которая считается от 12 (по X или Y) до ∞

        if (point_X< max_X && point_Y < limit_Y){
            is_M_in_N1 = true;
            Console.WriteLine($"Точка находится в область N1");
            
        }
        else {is_M_in_N4 = true; 
            Console.WriteLine($"Точка находится в область N4");  }

        break;
    case ( < 0, > 0):
        Console.WriteLine("Точка находится во второй четверти");

        limit_Y = Math.Abs (min_X + Math.Abs(point_X));

        //Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");
        if (point_X > min_X && point_Y < limit_Y) { is_M_in_N2 = true; 
            Console.WriteLine($"Точка находится в область N2"); }

        else { is_M_in_N3 = true; 
            Console.WriteLine($"Точка находится в область N3"); }

        break;
    case ( < 0, < 0):
        Console.WriteLine("Точка находится в третьей четверти");
        limit_Y = min_X - point_X;

        //Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");
        if (point_X > min_X && point_Y > limit_Y) { is_M_in_N1 = true;  
            Console.WriteLine($"Точка находится в область N1."); }
        else { is_M_in_N3 = true;  
            Console.WriteLine($"Точка находится в области N3."); }

        break;
    case ( > 0, < 0):
        Console.WriteLine("Точка находится в четвёртой четверти");
        limit_Y = min_X + Math.Abs(point_X);

        //Console.WriteLine($"Для точки ({point_X}, {point_Y}), макс. доп. значением Y является: {limit_Y}");
        if (point_X < max_X && point_Y < limit_Y) { is_M_in_N2 = true;  
            Console.WriteLine($"Точка находится в области N2.");  }

        else { is_M_in_N4 = true;  
            Console.WriteLine($"Точка находится в области N4."); }

        break;
}

