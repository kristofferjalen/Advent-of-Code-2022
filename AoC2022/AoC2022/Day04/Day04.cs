namespace AoC2022.Day04;

public class Day04
{
    private readonly string[] _lines;

    public Day04() => _lines = File.ReadAllLines("Day04/input.txt");

    public void Part1()
    {
        var sum = 0;

        foreach (var line in _lines)
        {
            var pairs = line.Split(',');

            var first = pairs[0].Split("-").Select(int.Parse).ToArray();
            var second = pairs[1].Split("-").Select(int.Parse).ToArray();

            var firstIsInside = first.Min() >= second.Min() && first.Max() <= second.Max();
            var secondIsInside = second.Min() >= first.Min() && second.Max() <= first.Max();

            sum += firstIsInside || secondIsInside ? 1 : 0;
        }
        
        Console.WriteLine(sum); // 530
    }

    public void Part2()
    {
        var sum = 0;

        foreach (var line in _lines)
        {
            var pairs = line.Split(',');

            var first = pairs[0].Split("-").Select(int.Parse).ToArray();
            var second = pairs[1].Split("-").Select(int.Parse).ToArray();

            var firstOverlap = first.Min() <= second.Max() && first.Max() >= second.Min();
            var secondOverlap = second.Min() <= first.Max() && second.Max() >= first.Min();
            
            sum += firstOverlap || secondOverlap ? 1 : 0;
        }

        Console.WriteLine(sum); // 903
    }
}