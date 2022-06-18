using Day62Demo.Data;
using Day62Demo.Data.Models;

public class AwaitAsyncTest
{
    private const string FilePath = @"C:\logs\test\Welcome.txt";

    public static void Demo()
    {
        SaveFile();
    }

    /// <summary>
    /// WriteAllText does the following tasks. Request OS to
    /// 1. create file
    /// 2. write "Hello Word"
    /// 3. save and close file
    /// </summary>
    public static void SaveFile()
    {
        File.WriteAllText(FilePath, "Hello World");

        Console.WriteLine("File successfully created");
    }

    // async - await
    public static async Task<bool> SaveFile2()
    {
        await File.WriteAllTextAsync(FilePath, "Hello World");

        Console.WriteLine("File successfully created");

        return true;
    }

    public static async Task EntityFrameworkDemo()
    {
        await using var dbContext = new ApplicationDbContext();

        var department = new Department
        {
            Id = 1,
            Name = "Sales"
        };

        //dbContext.Departments.Add(department);
        await dbContext.Departments.AddAsync(department);
        await dbContext.SaveChangesAsync();
    }
}