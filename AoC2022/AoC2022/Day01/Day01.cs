using BenchmarkDotNet.Attributes;

namespace AoC2022.Day01;

public class Day02
{
    private string text;

    [GlobalSetup]
    public void GlobalSetup()
    {
        text = File.ReadAllText("Day01/input.txt");
    }

    [Benchmark]
    public void Span()
    {
        var span = text.AsSpan();

        var top4 = new[] { 0, 0, 0, 0 };

        int i = 0, sum = 0;

        while (i < span.Length)
        {
            var nextLine = span[i..].IndexOf("\r\n");

            var number = int.Parse(span[i..(i + nextLine)]);

            sum += number;

            var b = span[(i + nextLine + 2)..].IndexOf("\r\n");

            if (b == 0)
            {
                top4[3] = sum;

                top4 = top4.OrderByDescending(x => x).ToArray();

                sum = 0;

                i += 2;
            }

            i += nextLine + 2;
        }

        //Console.WriteLine(top4[0]); // 70613
        //Console.WriteLine(top4[0] + top4[1] + top4[2]); // 205805
    }

    [Benchmark(Baseline = true)]
    public void String()
    {
        var lines = text.Split("\r\n");

        int i = 0, j = 0;

        var top4 = new[] { 0, 0, 0, 0 };

        while (i < lines.Length)
        {
            if (lines[i] == "")
            {
                top4[3] = j;
                top4 = top4.OrderByDescending(x => x).ToArray();
                j = 0;
            }
            else
            {
                j += int.Parse(lines[i]);
            }

            i++;
        }

        //Console.WriteLine(top4[0]); // 70613
        //Console.WriteLine(top4[0] + top4[1] + top4[2]); // 205805
    }
}