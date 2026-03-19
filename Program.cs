// // See https://aka.ms/new-console-template for more information

// using System;

// class Dog
// {
//     public string Name;
//     public string Breed;

//     public void Bark()
//     {
//         Console.WriteLine(Name + " says woooofff");


// }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog myDog = new Dog();
//         myDog.Name = "Bruno";
//         myDog.Breed = "German";

//         myDog.Bark();
//     }
// }

using System;


Calculator calc = new Calculator();
Console.WriteLine(calc.Add(5, 3));      
Console.WriteLine(calc.Multiply(4, 6));  


class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}