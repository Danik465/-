using System;

class Student
{
    public Guid id;
    public string FirstName;
    public string LastName;
    public string MiddleName;
    public int age;
    public string group;
}


class Program
{
    static Student GetStudent()
    {
        Student student = new Student();

        student.age = 19;
        student.FirstName = "Данила";
        student.LastName = "Обжерин";
        student.MiddleName = "Сергеевич";
        student.group = "МТЭ-2-21";
        student.id = Guid.NewGuid();

        return student;
    }

    static void Print(Student student)
    {
        Console.WriteLine("Информация о студенте:");
        Console.WriteLine($"1. Возраст: {student.age}");
        Console.WriteLine($"2. Имя {student.FirstName}");
        Console.WriteLine($"3. Фамилия {student.LastName}");
        Console.WriteLine($"4. Отчество {student.MiddleName}");
        Console.WriteLine($"5. Группа {student.group}");
        Console.WriteLine($"6. id {student.id}");
    }
    static void Main(string[] args)
    {
        Student firstStudent = GetStudent();

        Print(firstStudent);
    }
}