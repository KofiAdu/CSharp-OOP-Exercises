
public class StudentProfessorTest
{
    static void Main(String[] args)
    {
        Person person = new();
        Console.WriteLine(person.Greet());

        Student student = new ();
        student.SetAge(25);
        Console.WriteLine (student.Greet());
        Console.WriteLine(student.ShowAge());
        Console.WriteLine(student.Study());

        Teacher teacher = new ();
        teacher.SetAge(45);
        Console.WriteLine(teacher.Greet());
        Console.WriteLine(teacher.Explain());
    }
}
public class Person
{
    public int Age { get; set; }
    public string Greet()
    {
        return "Hello";
    }

    public int SetAge(int age)
    {
        Age = age;
        return Age;
    }
}

public class Student : Person
{
    public string Study()
    {
        return "I am studying";
    }

    public string ShowAge()
    {
        return "I am " + SetAge(Age) + " years old";
    }
}

public class Teacher  : Person
{
    public string Explain()
    {
        return "I am explaining";
    }
}
