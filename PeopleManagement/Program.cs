internal class Program
{
    private static void Main(string[] args)
    {
        CsvParser parser = new();
        List<Person> people = parser.Parse();
        // parser.PrintNames();
        PeopleReport.SaveMales(people);
        PeopleReport.SaveFemales(people);
        PeopleReport.SaveDotComUsers(people);
    }
}