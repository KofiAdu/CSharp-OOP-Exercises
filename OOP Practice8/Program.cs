// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Enter the name of your dog");
string name = Console.ReadLine();
Dog dog = new Dog();
dog.Name = name;
Console.WriteLine(dog.Name);
dog.Eat();

abstract class Animal
{
    public string Name { get; set; }
    public string GetName() => Name;
    public void SetName(string name) => Name = name;

    public abstract void Eat();
}

 class Dog : Animal
{
    public override void Eat() => Console.WriteLine($"{Name} is eating");
}

