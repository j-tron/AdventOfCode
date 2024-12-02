namespace AdventOfCode2024.Day1;

public class Day1
{
    private static readonly string[] separator = ["   "];

    public static int SolutionPart1(IReadOnlyList<int> left, IReadOnlyList<int> right)
    {
        left = [.. left.OrderBy(x => x)];
        right = [.. right.OrderBy(x => x)];
        var distance = 0;

        for (int i = 0; i < left.Count; i++)
        {
            distance += Math.Abs(left[i] - right[i]);
        }

        return distance;
    }

    public static int SolutionPart2(IReadOnlyList<int> left, IReadOnlyList<int> right)
    {
        left = [.. left.OrderBy(x => x)];
        right = [.. right.OrderBy(x => x)];

        var similarity = 0;

        for (int i = 0; i < left.Count; i++)
        {
            var duplication = 0;
            var lefty = left[i];
            for (int j = 0; j < right.Count; j++)
            {
                if(lefty == right[j])
                {
                    duplication++;
                }
            }

            similarity += lefty * duplication;
        }

        return similarity;
    }

    public static (IReadOnlyList<int> left, IReadOnlyList<int> right) ReadInput(string filePath)
    {
        string[] lines = File.ReadAllLines(Path.Combine(AppContext.BaseDirectory, filePath));

        List<int> left = [];
        List<int> right = [];

        foreach (string line in lines)
        {
            string[] parts = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            left.Add(int.Parse(parts[0]));
            right.Add(int.Parse(parts[1]));
        }

        return (left, right);
    }
}
