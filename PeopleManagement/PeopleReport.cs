class PeopleReport
{
    public static void SaveMales(List<Person>people)
    {
        string filePath=@"/Users/sandipchaudhary/Documents/Assignment/PeopleManagement/Data/males.csv";
        var males = people.Where(p => p.Gender == "Male").ToList();
        var csv = string.Join("\n", males.Select(m => $"{m.index},{m.userId},{m.firstName},{m.lastName},{m.Gender},{m.email},{m.phone},{m.dob},{m.jobTitle}"));
        File.WriteAllText(filePath, csv);
    }

    public static void SaveFemales(List<Person> people)
    {
        string filePath = @"/Users/sandipchaudhary/Documents/Assignment/PeopleManagement/Data/adultfemales.csv";
        var adultFemales = people.Where(p => p.Gender == "Female" && DateTime.Now.Year - p.dob.Year >= 20).ToList();
        var csv = string.Join("\n", adultFemales.Select(f => $"{f.index},{f.userId},{f.firstName},{f.lastName},{f.Gender},{f.email},{f.phone},{f.dob},{f.jobTitle}"));
        File.WriteAllText(filePath, csv);
    }

    public static void SaveDotComUsers(List<Person> people)
    {
        string filePath = @"/Users/sandipchaudhary/Documents/Assignment/PeopleManagement/Data/dotcomusers.csv";
        var dotComUsers = people.Where(p => p.email.EndsWith("@example.com")).ToList();
        var csv = string.Join("\n", dotComUsers.Select(d => $"{d.userId},{d.email},{d.phone}"));
        File.WriteAllText(filePath, csv);
    }
}