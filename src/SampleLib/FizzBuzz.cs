namespace SampleLib;

public class FizzBuzz
{
    private readonly TextWriter stdOut;

    public FizzBuzz(TextWriter stdOut)
    {
        this.stdOut = stdOut;
    }


    public void RunFizzBuzz(int until)
    {
        for (int i = 1; i <= until; i++)
        {
            var fizz = i % 3 == 0;
            var buzz = i % 5 == 0;

            switch ((fizz, buzz))
            {
                case (true, true):
                    stdOut.WriteLine("fizzbuzz");
                    break;

                case (true, false):
                    stdOut.WriteLine("fizz");
                    break;

                case (false, true):
                    stdOut.WriteLine("buzz");
                    break;

                default:
                    stdOut.WriteLine(i);
                    break;
            }
        }
    }
}
