/*
 * Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
 * Use contructors
 */

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return "Hello, my name is "+ Name;
    }
}

public class Program
{
    static void Main(String[] args)
    {
        int numOfPeople = 3;

        List<Person> persons = new();

        //for(int i = 0; i < numOfPeople; i++)
        //{
        //    string name = Console.ReadLine();
        //    Person person = new(name);
        //    persons.Add(person);
        //}

        for(int i = 0; i < numOfPeople; i++)
        {
            Person person = new(Console.ReadLine());
            persons.Add(person);
        }

        foreach(Person person in persons)
        {
            Console.WriteLine(person.ToString());
        }

    }
}