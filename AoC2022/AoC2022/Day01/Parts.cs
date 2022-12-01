namespace AoC2022.Day01;

internal class Parts
{
    public void Run()
    {
        var lines = File.ReadAllLines("Day01/input.txt");

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
        
        Console.WriteLine(top4[0]); // 70613
        Console.WriteLine(top4[0] + top4[1] + top4[2]); // 205805
    }
}