double g = 9.81;
double t = 0;
double y = 0;
double x = 0;

Console.WriteLine("Введите начальные координаты x");
string x0 = Console.ReadLine();

foreach (char c in x0)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}

double x1 = Convert.ToDouble(x0);

Console.WriteLine("Введите начальные координаты y");
string y0 = Console.ReadLine();

foreach (char c in y0)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}
double y1 = Convert.ToDouble(y0);

Console.WriteLine("Введите начальную скорость");
string v0 = Console.ReadLine();

foreach (char c in v0)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}

double v1 = Convert.ToDouble(v0);


Console.WriteLine("Введите угол вылета снаряда (в градусах)");
string ugol = Console.ReadLine();

double ugol_check = Convert.ToDouble(ugol);

if (ugol_check < 0 ||  ugol_check > 360) 
{
        Console.WriteLine("Вы ввели градус меньше 0 либо больше 360");
        return;
}
if (y1 == 0 )
{
    if (ugol_check >= 181)
    {
        Console.WriteLine("По условию вы ввели y = 0, по этому угол может быть только меньше 180");
        return;
    }
}
else
{
}

foreach (char c in ugol)
{
    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
    {
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимый символ");
        return;
    }
}

double ugol_rad = ugol_check * Math.PI / 180;

double v0x = v1 * Math.Cos(ugol_rad);
double v0y = v1 * Math.Sin(ugol_rad);

while (true)
{
    if (y >= 0)
    {
        y = y1 + v0y * t - (g * Math.Pow(t, 2) / 2);
        x = x1 + v0x * t;
    }
    else
    {
        break;
    }
    Console.WriteLine($"x: {x} y: {y}");
    t += 0.1;

}


