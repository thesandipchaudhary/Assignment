
internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = @"/Users/sandipchaudhary/Documents/Assignment/PeopleManagement/People.csv";

        CSVParser Parser = new CSVParser();
        Parser.Parse(filePath);
        Parser.PrintNames();
    }
}