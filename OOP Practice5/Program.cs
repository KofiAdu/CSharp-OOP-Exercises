// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int numOfPeople =3;

Person[] people = new Person[numOfPeople];


for(int i = 0; i < numOfPeople; i++)
{
    if(i == 0)
    {
        people[i] = new Teacher(Console.ReadLine());
    }
    else
    {
        people[i] = new Student(Console.ReadLine());
    }
}

for (int i = 0; i < numOfPeople; i++)
{
    if(i == 0)
    {
        Console.WriteLine(((Teacher)people[i]).Explain());
    }
    else
    {
        Console.WriteLine(((Student)people[i]).Study());
    }
}



//for(int i = 0; i < numOfPeople; i++)
//{
//    people[i] =
//}
//foreach(Person person in people)
//{
//    //if(person.GetType() == typeof(Teacher))
//    //{
//    //    Console.WriteLine(person.Explain());
//    //}
//    Console.WriteLine(person);
//}


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

public class Student : Person
{
    //calling the base constructor frm the parent class
    public Student( string name) : base(name)
    {
    }

    public string Study()
    {
        return "Study";
    }
}

public class  Teacher : Person
{
    public Teacher(string name) : base(name)
    { 
    }

    public string Explain()
    {
        return "Explain";
    }
}