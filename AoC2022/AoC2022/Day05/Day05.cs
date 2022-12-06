using System.Collections;

namespace AoC2022.Day05;

public class Day05
{
    private readonly string[] _text;

    public Day05() => _text = File.ReadAllLines($"{GetType().Name}/input.txt").ToArray();

    public void Part1()
    {
        var stacks = new Stack<char>[9];
        stacks[0] = new Stack<char>();
        stacks[0].Push('Z');
        stacks[0].Push('J');
        stacks[0].Push('G');
        stacks[1] = new Stack<char>();
        stacks[1].Push('Q');
        stacks[1].Push('L');
        stacks[1].Push('R');
        stacks[1].Push('P');
        stacks[1].Push('W');
        stacks[1].Push('F');
        stacks[1].Push('V');
        stacks[1].Push('C');
        stacks[2] = new Stack<char>();
        stacks[2].Push('F');
        stacks[2].Push('P');
        stacks[2].Push('M');
        stacks[2].Push('C');
        stacks[2].Push('L');
        stacks[2].Push('G');
        stacks[2].Push('R');
        stacks[3] = new Stack<char>();
        stacks[3].Push('L');
        stacks[3].Push('F');
        stacks[3].Push('B');
        stacks[3].Push('W');
        stacks[3].Push('P');
        stacks[3].Push('H');
        stacks[3].Push('M');
        stacks[4] = new Stack<char>();
        stacks[4].Push('G');
        stacks[4].Push('C');
        stacks[4].Push('F');
        stacks[4].Push('S');
        stacks[4].Push('V');
        stacks[4].Push('Q');
        stacks[5] = new Stack<char>();
        stacks[5].Push('W');
        stacks[5].Push('H');
        stacks[5].Push('J');
        stacks[5].Push('Z');
        stacks[5].Push('M');
        stacks[5].Push('Q');
        stacks[5].Push('T');
        stacks[5].Push('L');
        stacks[6] = new Stack<char>();
        stacks[6].Push('H');
        stacks[6].Push('F');
        stacks[6].Push('S');
        stacks[6].Push('B');
        stacks[6].Push('V');
        stacks[7] = new Stack<char>();
        stacks[7].Push('F');
        stacks[7].Push('J');
        stacks[7].Push('Z');
        stacks[7].Push('S');
        stacks[8] = new Stack<char>();
        stacks[8].Push('M');
        stacks[8].Push('C');
        stacks[8].Push('D');
        stacks[8].Push('P');
        stacks[8].Push('F');
        stacks[8].Push('H');
        stacks[8].Push('B');
        stacks[8].Push('T');

        var agmts = _text.Skip(10);

        foreach (var a in agmts)
        {
            var i = a.IndexOf(" from");
            var n = a.Substring(5, i - 5);

            var j = a.IndexOf(" to");
            var f = a.Substring(i + 5, j - (i + 5));

            var t = a[(j + 3)..];

            var number = int.Parse(n);
            var from = int.Parse(f) - 1;
            var to = int.Parse(t) - 1;

            for (var x = 0; x < number; x++)
            {
                var a1 = stacks[from].Pop();
                stacks[to].Push(a1);
            }
        }

        var final = "";
        foreach (var stack in stacks)
        {
            final += stack.Pop();
        }

        Console.WriteLine(final); // WSFTMRHPP
    }

    public void Part2()
    {
        var stacks = new Stack<char>[9];
        stacks[0] = new Stack<char>();
        stacks[0].Push('Z');
        stacks[0].Push('J');
        stacks[0].Push('G');
        stacks[1] = new Stack<char>();
        stacks[1].Push('Q');
        stacks[1].Push('L');
        stacks[1].Push('R');
        stacks[1].Push('P');
        stacks[1].Push('W');
        stacks[1].Push('F');
        stacks[1].Push('V');
        stacks[1].Push('C');
        stacks[2] = new Stack<char>();
        stacks[2].Push('F');
        stacks[2].Push('P');
        stacks[2].Push('M');
        stacks[2].Push('C');
        stacks[2].Push('L');
        stacks[2].Push('G');
        stacks[2].Push('R');
        stacks[3] = new Stack<char>();
        stacks[3].Push('L');
        stacks[3].Push('F');
        stacks[3].Push('B');
        stacks[3].Push('W');
        stacks[3].Push('P');
        stacks[3].Push('H');
        stacks[3].Push('M');
        stacks[4] = new Stack<char>();
        stacks[4].Push('G');
        stacks[4].Push('C');
        stacks[4].Push('F');
        stacks[4].Push('S');
        stacks[4].Push('V');
        stacks[4].Push('Q');
        stacks[5] = new Stack<char>();
        stacks[5].Push('W');
        stacks[5].Push('H');
        stacks[5].Push('J');
        stacks[5].Push('Z');
        stacks[5].Push('M');
        stacks[5].Push('Q');
        stacks[5].Push('T');
        stacks[5].Push('L');
        stacks[6] = new Stack<char>();
        stacks[6].Push('H');
        stacks[6].Push('F');
        stacks[6].Push('S');
        stacks[6].Push('B');
        stacks[6].Push('V');
        stacks[7] = new Stack<char>();
        stacks[7].Push('F');
        stacks[7].Push('J');
        stacks[7].Push('Z');
        stacks[7].Push('S');
        stacks[8] = new Stack<char>();
        stacks[8].Push('M');
        stacks[8].Push('C');
        stacks[8].Push('D');
        stacks[8].Push('P');
        stacks[8].Push('F');
        stacks[8].Push('H');
        stacks[8].Push('B');
        stacks[8].Push('T');

        var agmts = _text.Skip(10);

        foreach (var a in agmts)
        {
            var i = a.IndexOf(" from");
            var n = a.Substring(5, i - 5);

            var j = a.IndexOf(" to");
            var f = a.Substring(i + 5, j - (i + 5));

            var t = a.Substring(j + 3);

            var number = int.Parse(n);
            var from = int.Parse(f) - 1;
            var to = int.Parse(t) - 1;


            var temp = new Stack<char>();
            for (var x = 0; x < number; x++)
            {
                var a1 = stacks[from].Pop();
                temp.Push(a1);
                //stacks[to].Push(a1);
            }
            while (temp.Any())
            {
                var a1 = temp.Pop();
                stacks[to].Push(a1);
            }
        }

        var final = "";
        foreach (var stack in stacks)
        {
            final += stack.Pop();
        }

        Console.WriteLine(final); // WSFTMRHPP
    }

}