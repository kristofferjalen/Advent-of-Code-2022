namespace AoC2022.Day02;

public class Day02
{
    private readonly string[] _lines;

    public Day02() => _lines = File.ReadAllLines("Day02/input.txt");

    public void Part1()
    {
        var sum = _lines.Sum(round => round switch
        {
            "A X" => 1 + 3,
            "A Y" => 2 + 6,
            "A Z" => 3 + 0,
            "B X" => 1 + 0,
            "B Y" => 2 + 3,
            "B Z" => 3 + 6,
            "C X" => 1 + 6,
            "C Y" => 2 + 0,
            "C Z" => 3 + 3
        });

        Console.WriteLine(sum); // 12679
    }

    public void Part2()
    {
        var sum = _lines.Sum(round => round switch
        {
            "A X" => 3 + 0,
            "A Y" => 1 + 3,
            "A Z" => 2 + 6,
            "B X" => 1 + 0,
            "B Y" => 2 + 3,
            "B Z" => 3 + 6,
            "C X" => 2 + 0,
            "C Y" => 3 + 3,
            "C Z" => 1 + 6
        });

        Console.WriteLine(sum); // 14470
    }
}