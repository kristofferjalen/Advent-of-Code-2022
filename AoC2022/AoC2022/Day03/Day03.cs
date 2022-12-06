using BenchmarkDotNet.Attributes;
using System.Numerics;

namespace AoC2022.Day03;

public class Day04
{
    private string _text;
    //private readonly string[] _lines;

    public Day04()
    {
        //_lines = File.ReadAllLines("Day03/input.txt");
        _text = File.ReadAllText("Day03/input.txt");
    }

    //[GlobalSetup]
    //public void Setup()
    //{
    //    _text = File.ReadAllText("Day03/input.txt");
    //}

    //[Benchmark(Baseline =true)]
    //public void Part1()
    //{
    //    var sum = 0;

    //    var _lines = _text.Split(Environment.NewLine);

    //    foreach (var line in _lines)
    //    {
    //        var first = line[..(line.Length / 2)];

    //        var second = line[(line.Length / 2)..];

    //        var shared = first.First(x => second.Contains(x));

    //        sum += char.IsUpper(shared) ? shared - 65 + 27 : shared - 97 + 1;
    //    }

    //    Console.WriteLine(sum); // 8039
    //}

    //[Benchmark]
    public void Part1Span()
    {
        var sum = 0;

        var span = _text.AsSpan();

        var i = 0;

        while (i < span.Length)
        {
            var newline = span[i..].IndexOf(Environment.NewLine);

            var first = span[i..(newline / 2)];

            var second = span[(newline / 2)..newline];

            var found = false;
            var j = -1;
            
            while (!found && j++ < first.Length)
            {
                var k = 0;
                while (!found && k < second.Length)
                {
                    found = first[j] == second[k];
                    k++;
                }
            }

            var shared = first[j];

            sum += char.IsUpper(shared) ? shared - 65 + 27 : shared - 97 + 1;

            i += newline;
        }

        Console.WriteLine(sum); // 8039
    }


    //public void Part2()
    //{
    //    var i = 0;

    //    var sum = 0;

    //    while (i < _lines.Length)
    //    {
    //        var group = _lines.Skip(i).Take(3).ToArray();

    //        var shared = group[0].First(x => group[1].Contains(x) && group[2].Contains(x));

    //        sum += char.IsUpper(shared) ? shared - 65 + 27 : shared - 97 + 1;

    //        i += 3;
    //    }

    //    Console.WriteLine(sum); // 2510
    //}
}