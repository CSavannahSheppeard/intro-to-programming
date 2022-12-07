
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        return numbers == "" ? 0 : numbers.Split(',').Select(int.Parse).Sum();
    }
}
