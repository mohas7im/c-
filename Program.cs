// See https://aka.ms/new-console-template for more information

using System;

class Dog
{
    public string Name;
    public string Breed;

    public void Bark()
    {
        Console.WriteLine(Name + " says woooofff");


}
}
class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Name = "Bruno";
        myDog.Breed = "German";

        myDog.Bark();
    }
}

