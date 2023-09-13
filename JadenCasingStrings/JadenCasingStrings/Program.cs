using JadenCasingStrings;
internal class Program
{
    private static void Main(string[] args)
    {
        var test = new Implement();
        
        string prahse = "a a a a a a aaa a a a a a a a ";

        Console.WriteLine(test.ToJadenCase(prahse));
    }
}