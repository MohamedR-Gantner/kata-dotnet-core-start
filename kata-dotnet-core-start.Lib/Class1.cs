namespace kata_dotnet_core_start.Lib;
public class Class1
{
    public static List<int> Generate()
    {
        return Enumerable.Range(1, 100).ToList();
    }

    public static List<string> FizzBuzzify(List<int> list)
    {
        //return list.Select(i => i.ToString()).ToList();

        return list.Select(i =>
        {
            if (i % 15 == 0)
                return "FizzBuzz";
            if (i % 3 == 0)
                return "Fizz";
            if (i % 5 == 0)
                return "Buzz";
            return i.ToString();
        }).ToList();
    }
}
