﻿// See https://aka.ms/new-console-template for more information

using methods;





int number;

bool isConverted = int.TryParse("ABC", out number);//remeber tryparse does not throw an exception and thats why return a boolean.

if(isConverted)
{
    Console.WriteLine(number);

}
else
{ 
    Console.WriteLine("Unable to convert");
}




static void USeParams()
{

    Calculator Calculator = new Calculator();
    Console.WriteLine(Calculator.Add(10, 20));
    Console.WriteLine(Calculator.Add(10, 20, 30));
    Console.WriteLine(Calculator.Add(new int[] { 10, 20, 30, 40, 50, 60 })); //no need to do this as we already using params keyword but just to know that we can do that as well
}



static void UsePoints()
{
    try
    {
        Console.WriteLine("Hello, World!");
        Point point = new Point(10, 20);

        Console.WriteLine($"X: {point.x}, Y: {point.y}");
        point.move(null);


        Console.WriteLine($"X: {point.x}, Y: {point.y}");

        point.move(400, 500);

        Console.WriteLine($"X: {point.x}, Y: {point.y}");
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("An expected error occured. ");
    }
}
