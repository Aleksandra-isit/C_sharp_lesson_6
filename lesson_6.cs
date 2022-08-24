/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
int[] InputData()
{
    Console.Write("Введите количество чисел: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите числа: ");
    string[] tokens = Console.ReadLine().Split();
    int i = 0;
    int[] Array = new int[M];
    for (; i < M; i++)
    {
        Array[i] = int.Parse(tokens[i]);
    }
    return Array;
}
 
void Show(int[] Array)
{
    Console.WriteLine("\nВы ввели:");
    int M = Array.Length, i = 0;
    for (; i < M; i++)
        Console.Write($"{Array[i]} ");
    Console.WriteLine("\n");
}

int Count(int[] Array)
{
    int i = 0, count = 0, M = Array.Length;
    for (; i < M; i++)
    {
        if (Array[i] > 0) count++;
    }
    return count;
}

Console.Clear();
int[] Array = InputData();
Show(Array);
int count = Count(Array);
Console.WriteLine($"Чисел больше 0:  {count}\n");
*/


/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double[,] Input()
{
    int i, j;
    double[,] data = new double[2,2];
    string[,] value = { {"k1", "b1"}, {"k2", "b2"} };
    for (i = 0; i < 2; i++)
        for (j = 0; j < 2; j++)
        {
            Console.Write($"{value[i,j]} = ");
            data[i,j] = Convert.ToDouble(Console.ReadLine());
        }

    Console.WriteLine("Первое уравнение: ");
    Console.WriteLine($"y = {data[0, 0]} * x + {data[0, 1]}");
    Console.WriteLine("Второе уравнение: ");
    Console.WriteLine($"y = {data[1, 0]} * x + {data[1, 1]}");
    return data;
}

void Coord(double[,] data, double[] coord)
{
    coord[0] = (data[1,1] - data[0,1])/(data[0,0] - data[1,0]);
    coord[1] = coord[0] * data[0,0] + data[0,1];
    Console.WriteLine($"Координаты точки: ({coord[0]},{coord[1]})");
}

void proverka(double[,] data, double[] coord)
{
    if (data[0,0] == data[1,0] && data[0,1] == data [1,1])
    {
        Console.WriteLine("Прямые совпадают"); return;
    }
    else if (data[0,0] == data[1,0])
    {
        Console.WriteLine("Прямые параллельны"); return;
    }
    Coord(data, coord);   
}

Console.Clear();
double[,] data = Input();
double[] coord = new double[2];
proverka(data, coord);



