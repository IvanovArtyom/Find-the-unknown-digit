using System.Data;

public class Runes
{
    public static void Main()
    {
        // Test
        var t = solveExpression("?*11=??");
        // ...should return 2
    }

    public static int solveExpression(string expression)
    {
        for (int i = 0; i <= 9; i++)
        {
            if (expression.Contains(i.ToString()))
                continue;

            string[] parts = expression.Replace('?', (char)(i + 48)).Split('=');

            if (new DataTable().Compute(parts[0], "").ToString() == parts[1])
                return i;
        }

        return -1;
    }
}