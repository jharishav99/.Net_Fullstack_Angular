using System;
using System.Collections.Generic;
using System.Linq;

public class PropertyDemo
{
   
    public int PublicValue { get; set; } = 5;

   
    private string _privateValue = "Private Value";
    public string PrivateValueDisplay => _privateValue;
}


public class StaticDemo
{
    public static int StaticValue;

   
    static StaticDemo()
    {
        
        Console.WriteLine("Static Constructor");
        StaticValue = 10;
    }

    
    public static void DisplayStaticMethod()
    {
        Console.WriteLine("Static Method");
    }
}


public static class MathHelper
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
}


public class Program
{
    public static void Main(string[] args)
    {
        
        PropertyDemo p = new PropertyDemo();
        Console.WriteLine(p.PublicValue);        
        Console.WriteLine(p.PrivateValueDisplay); 

        Console.WriteLine(StaticDemo.StaticValue); 
        StaticDemo.DisplayStaticMethod();          

        Console.WriteLine(MathHelper.Add(10, 5));      
        Console.WriteLine(MathHelper.Subtract(10, 5));

        Console.WriteLine(" ");

        
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var names = new List<string> { "Ram", "Shyam", "Pawan", "Sharad", "Uchit" };
        var people = new List<(string Name, int Age)>
        {
            ("Ram", 30), ("Shyam", 25), ("Pawan", 35), ("Sharad", 28), ("Uchit", 22)
        };

        
        var evenNum = numbers.Where(n => n % 2 == 0);
        var squaredNum = numbers.Select(n => n * n);
        var nameWithR = names.Where(n => n.StartsWith("R"));

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNum));
        Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNum));
        Console.WriteLine("Names starting with R: " + string.Join(", ", nameWithR));

        
        var sortedPeople = people.OrderBy(p1 => p1.Age).ThenBy(p1 => p1.Name);
        Console.WriteLine("\nSorted people by age:");
        foreach (var person in sortedPeople)
            Console.WriteLine($"- {person.Name} ({person.Age})");

        
        Console.WriteLine($"\nSum: {numbers.Sum()}");
        Console.WriteLine($"Average: {numbers.Average()}");
        Console.WriteLine($"Contains 3? {numbers.Contains(3)}");

       
        var firstThree = numbers.Take(3);
        Console.WriteLine("First three: " + string.Join(", ", firstThree));

        
        var firstOrDefault = numbers.FirstOrDefault(n => n > 100); 
        Console.WriteLine($"First > 100: {firstOrDefault}");
    }
}