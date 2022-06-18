using System.Collections;

namespace Day62Demo;

public static class GenericsTest
{
    public static void Demo()
    {
        jump(10, "aaaa");   // Dear aaa, Please leave the movie theater
        jump(20, "xxxx");   // Dear xxxx, Welcome! Enjoy the movie!

        // DataType Parameters
        // Collection are the most important data types in any live project

        ArrayList students = new ArrayList();

        students.Add(new Student { Id = 1, Name = "AAA" });
        students.Add(new Student { Id = 1, Name = "AAA" });
        students.Add("dsdsdsd");
        students.Add("Hello");

        var s = (Student)students[0];
        Console.WriteLine(s.Name);

        var n = (int)students[2];
        Console.WriteLine(n * n);

        // Generics
        List<Student> students2 = new List<Student>();
        students2.Add(new Student { Id = 1, Name = "AAA" });
        students2.Add(new Student { Id = 1, Name = "AAA" });

        var leader = new WaiItLeader<int>();

        leader.Jump<string>("Aaaa");
    }

    static void jump(int age, string name)
    {
        if (age < 18)
            Console.WriteLine($"Dear {name}, Please leave the movie theater");
        else
            Console.WriteLine($"Dear {name}, Welcome! Enjoy the movie!");
    }

}