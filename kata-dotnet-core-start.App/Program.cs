// See https://aka.ms/new-console-template for more information

using kata_dotnet_core_start.Lib;

var numbers = Class1.Generate();
var fizzBuzzList = Class1.FizzBuzzify(numbers);

foreach (var item in fizzBuzzList)
{
    Console.WriteLine(item);
}

Console.ReadLine();
