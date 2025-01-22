namespace Challenges._01_Islands;

public abstract class IslandsCounter(string[,] map, bool debugOutput)
{
    protected readonly string[,] Map = map;

    protected int Count = 0;

    protected bool DebugOutput = debugOutput;

    protected bool IsValidLandTile((int i, int j) tile) =>
        0 <= tile.i && tile.i < Map.GetLength(0) &&
        0 <= tile.j && tile.j < Map.GetLength(1) &&
        Map[tile.i, tile.j] == "1";

    protected void PrintMap(string? message = null)
    {
        if (message != null)
        {
            Console.WriteLine(message);
        }

        for (var i = 0; i < Map.GetLength(0); i++)
        {
            for (var j = 0; j < Map.GetLength(1); j++)
            {
                Console.Write(" {0} ", Map[i, j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}