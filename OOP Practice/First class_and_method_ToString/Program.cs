/*
 * Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person.
 */

public class Person
{
    public string Name { get; set; }

    public override string ToString()
    {
        return "Hello, my name is " + Name;
    }
}


public class Program
{
    static void Main(String[] args)
    {
        int numOfPersons = 3;
        Person person = new Person();
        List<Person> personList = new List<Person>();

        for (int i = 0; i < numOfPersons; i++)
        {
            personList.Add(new Person()
            {
                Name = Console.ReadLine()
            });
        }

        foreach (Person person1 in personList)
        {
            Console.WriteLine(person1.ToString());
        }
    }
}
