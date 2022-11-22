namespace kata_dotnet_core_start.Lib;
public class Class1
{
    public static List<int> Generate()
    {
        return Enumerable.Range(1, 100).ToList();
    }

    public static List<string> FizzBuzzify(List<int> list)
    {
        return list.Select(i => i.ToString()).ToList();
    }
}
