namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void Generate_sequence_100_integers()
    {
        var list = Class1.Generate();
        Assert.Equal(100, list.Count);
    }
    
    [Fact]
    public void Sequence_starts_at_1()
    {
        var list = Class1.Generate();
        Assert.Equal(1, list.First());
    }
    
    [Fact]
    public void Sequence_ends_at_100()
    {
        var list = Class1.Generate();
        Assert.Equal(100, list.Last());
    }
    
    [Fact]
    public void FizzBuzz_sequence_no_Fizz_or_Buzz_at_number()
    {
        var list = Class1.Generate();
        var seq = Class1.FizzBuzzify(list);
        
        Assert.Equal("7", seq[6]);
    }
    
    [Fact]
    public void FizzBuzz_sequence_prints_Fizz_at_3()
    {
        var list = Class1.Generate();
        var seq = Class1.FizzBuzzify(list);

        Assert.Equal("Fizz", seq[2]);
        Assert.Equal("Fizz", seq[5]);
    }

    [Fact]
    public void FizzBuzz_sequence_prints_Buzz_at_5()
    {
        var list = Class1.Generate();
        var seq = Class1.FizzBuzzify(list);
        
        Assert.Equal("Buzz", seq[4]);
        Assert.Equal("Buzz", seq[99]);
    }

    [Fact]
    public void FizzBuzz_sequence_prints_FizzBuzz_at_15()
    {
        var list = Class1.Generate();
        var seq = Class1.FizzBuzzify(list);
        
        Assert.Equal("FizzBuzz", seq[14]);
    }
    
    
}