using System.IO;
using Xunit;

namespace SampleLib.Test;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(3, "1\r\n2\r\nfizz")]
    public void Writes_expected_outout_to_stdOut(int input, string expected)
    {
        var stdOut = new StringWriter();
        var sut = new FizzBuzz(stdOut);
        sut.RunFizzBuzz(input);

        var output = stdOut.ToString();
        Assert.StartsWith(expected, output);
    }
}