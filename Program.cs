#nullable disable
 

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("___Tusk 25____");
System.Console.WriteLine("Enter Number 1: ");
int NumberA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter Number 2: ");
int NumberB = int.Parse(Console.ReadLine());


int UP (int NumA, int Pow)
{ 
    int result = 1;
    for(int i = 0; i < Pow; i++)
    {
        result = result * NumA;
    }
   
    
    return result;
}
System.Console.WriteLine($"A POW B = {UP(NumberA, NumberB)}");




/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("___Tusk 27____");
System.Console.WriteLine("Enter Number 1: ");
int Egor = int.Parse(Console.ReadLine());

if(Egor < 0)
{
    System.Console.WriteLine("Error, Enter number > 0");
}
else
{
System.Console.WriteLine($"Suma = {Module(Egor)}");
}



int Module (int temporery)
{
    int g = 0;
    for(; temporery != 0; temporery /= 10)
    {    
        g = g + temporery % 10;
    }
return g;
}



/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("___Tusk____ ");

System.Console.WriteLine("Нажмите любую цифру, что бы продолжить: ");
int A = int.Parse(Console.ReadLine());

int [] Size = RandomMassiv(8, -5, 3);


int [] RandomMassiv(int size, int min, int max)
{
    int [] res = new int [size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max+1);
    }
    return res;
}
System.Console.WriteLine(String.Join(" ", Size));