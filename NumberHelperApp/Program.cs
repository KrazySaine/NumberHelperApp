
public class NumberHelper
{
    static void Main(string[] args)
    { }



    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    public int DoubleIt(int number)
    {
        return number * 2;
    }
}

