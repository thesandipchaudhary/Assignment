using System;
using System.Collections.Generic;
using System.IO;

public class CSVParser
{
    private List<Person> people;

    public CSVParser()
    {
        people = new List<Person>();
    }

    public void Parse(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        Person person = new Person
                        {
                            Index = parts[0],
                            FirstName = parts[2],
                            LastName = parts[3]
                        };
                        people.Add(person);
                    }
                }
            }
        }
    }

    public void PrintNames()
    {
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Index} {person.FirstName} {person.LastName}");
        }
    }
}
