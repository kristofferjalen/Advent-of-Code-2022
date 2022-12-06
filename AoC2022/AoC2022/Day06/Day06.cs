namespace AoC2022.Day06;

public class Day06
{
    private readonly string _text;

    public Day06() => _text = File.ReadAllText($"{GetType().Name}/input.txt");

    public void Part1()
    {
        var i = Subroutine(4);

        Console.WriteLine(i); // 1833
    }

    public void Part2()
    {
        var i = Subroutine(14);

        Console.WriteLine(i); // 3425
    }

    private int Subroutine(int limit)
    {
        var i = limit;

        var notFound = true;

        while (notFound)
        {
            notFound = _text
                .Skip(i - limit)
                .Take(limit)
                .Distinct()
                .Count() != limit;

            i++;
        }

        return i - 1;
    }
}