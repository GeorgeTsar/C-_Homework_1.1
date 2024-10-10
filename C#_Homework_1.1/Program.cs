// See https://aka.ms/new-console-template for more information

// ЗАДАНИЕ 1
Console.WriteLine("It's easy to win forgiveness for being wrong;  \r\nbeing right is what gets you into real trouble.\r\nBjarne Stroustrup");

Console.WriteLine("\n---------------------------------------------------------------------\n");

// ЗАДАНИЕ 2
int a, b, c, d, e;

Console.WriteLine("Введите целое число: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
d = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
e = int.Parse(Console.ReadLine());
Console.WriteLine("Результат {0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, a + b + c + d + e);
Console.WriteLine("Результат {0} * {1} * {2} * {3} * {4} = {5}", a, b, c, d, e, a * b * c * d * e);

int min = a;
for (int i = 0; i < 5; i++)
{
    if (a > b)
    {
        min = b;
    }
    if (b > c)
    {
        min = c;
    }
    if (c > d)
    {
        min = d;
    }
    if (d > e)
    {
        min = e;
    }
}
Console.WriteLine("\nМинимальное число:\n");
Console.WriteLine(min);

int max = a;
for (int i = 0; i < 5; i++)
{
    if (a < b)
    {
        max = b;
    }
    if (b < c)
    {
        max = c;
    }
    if (c < d)
    {
        max = d;
    }
    if (d < e)
    {
        max = e;
    }
}
Console.WriteLine("\nМаксимальное число:\n");
Console.WriteLine(max);


Console.WriteLine("\n---------------------------------------------------------------------\n");

// ЗАДАНИЕ 3
Console.WriteLine("Введите шестизначное число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;
int a = number % 10;
number = number / 10;
result += a * 10000;

a = number % 10;
number = number / 10;
result += a * 1000;

a = number % 10;
number = number / 10;
result += a * 100;

a = number % 10;
number = number / 10;
result += a * 10;

a = number % 10;
number = number / 10;
result += a;

Console.WriteLine(result);


Console.WriteLine("\n---------------------------------------------------------------------\n");

//ЗАДАНИЕ 4
int last;
Console.WriteLine("Введите последнее число диапазона: ");
last = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
for (int i = 0; i <= last; i++)
{
    int c = a;
    a = b;
    b = c + b;
    Console.WriteLine(a);
}


Console.WriteLine("\n---------------------------------------------------------------------\n");

//ЗАДАНИЕ 5
int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}


Console.WriteLine("\n---------------------------------------------------------------------\n");

// ЗАДАНИЕ 6
Console.WriteLine("Введите символ-заполнитель: ");
char a = char.Parse(Console.ReadLine());
Console.WriteLine("Введите длину строки: ");
int l = int.Parse(Console.ReadLine());
Console.WriteLine("Направление линии по вертикали (1) или по горизонтали (2)?");
int b = int.Parse(Console.ReadLine());
for (int i = 0; i < l; i++)
{
    if (b == 1)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(a);
        break;
    }
}