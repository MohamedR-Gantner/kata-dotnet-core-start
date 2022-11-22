namespace kata_dotnet_core_start.Lib;
public class Class1
{
    public static List<int> Generate()
    {
        return Enumerable.Range(1, 100).ToList();
    }

    public static List<string> FizzBuzzify(List<int> list)
    {
        return list.Select(Fizzbuzzify).ToList();
    }

    public static string Fizzbuzzify(int i)
    {
        if (IsDivisibleByThree(i) && IsDivisibleByFive(i))
            return "FizzBuzz";
        if (IsDivisibleByThree(i))
            return "Fizz";
        if (IsDivisibleByFive(i))
            return "Buzz";
        return i.ToString();
    }

    private static bool IsDivisibleByThree(int i)
    {
        return i % 3 == 0;
    }

    private static bool IsDivisibleByFive(int i)
    {
        return i % 5 == 0;
    }
}
