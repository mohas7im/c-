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

// using System;


// Calculator calc = new Calculator();
// Console.WriteLine(calc.Add(5, 3));      
// Console.WriteLine(calc.Multiply(4, 6));  


// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public int Multiply(int a, int b)
//     {
//         return a * b;
//     }
// }

// BankAccount acc = new BankAccount("Priya", 15000);
// acc.ShowBalance();
// class BankAccount
// {
//     public string Owner;
//     public double Balance;

//     public BankAccount(string owner, double balance)
//     {
//         Owner = owner;
//         Balance = balance;
//     }

//     public void ShowBalance()
//     {
//         Console.WriteLine(Owner + "'s balance " + Balance);

//     }
// }


// Student s = new Student();
// s.Age = 20;
// s.Age = -5;
// Console.WriteLine(s.Age);

// class Student
// {
//     private int age;
//     public int Age

//     {
//         get { return age; }
//         set
//         {
//             if (value >= 0)
//                 age = value;
//             else
//                 Console.WriteLine("Invalid age!");

//         }
//     }


// }

// Employee e = new Employee();
// e.Salary = 50000;
// e.ShowSalary();
// e.Salary = -100;


// class Employee
// {
//     private double salary;
//     public double Salary
//     {
//         get
//         {
//             return salary;
//         }
//         set
//         {
//             if (value > 0)
//             salary = value;

//             else
//             Console.WriteLine("salary must be positive");

//         }
//     }
//     public void ShowSalary()
//     {
//         Console.WriteLine("Employee salary"+salary);
//     }
// }

Dog d = new Dog();
d.Name = "rex";
d.Eat();
d.Bark();


class Animal
{
    public string Name;
    public void Eat()
    {
            Console.WriteLine(Name + "is eating ");     
    }

}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + "says : woof !");


    }
}

