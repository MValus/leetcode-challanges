namespace Challenges._01_Islands;

public class IslandsDfsCounter : IslandsCounter
{
    private IslandsDfsCounter(string[,] map, bool debugOutput) : base(map, debugOutput)
    {
    }

    public static int CountIslands(string[,] map, bool debugOutput = false)
    {
        var counter = new IslandsDfsCounter(map, debugOutput);
        if (counter.DebugOutput) counter.PrintMap("Input map:");
        for (var i = 0; i < map.GetLength(0); i++)
        {
            for (var j = 0; j < map.GetLength(1); j++)
            {
                if (!counter.IsValidLandTile((i, j))) continue;
                counter.Count++;
                counter.MarkAsVisitedAndExplore((i, j));
            }
        }

        return counter.Count;
    }

    private void MarkAsVisitedAndExplore((int i, int j) tile)
    {
        if (!IsValidLandTile(tile)) return;

        if (DebugOutput)
        {
            Map[tile.i, tile.j] = "x";
            PrintMap("Discovering island #" + Count + ":");
        }
        else
        {
            Map[tile.i, tile.j] = "0";
        }

        // look right
        MarkAsVisitedAndExplore((tile.i, tile.j + 1));
        // look down
        MarkAsVisitedAndExplore((tile.i + 1, tile.j));
        // look left
        MarkAsVisitedAndExplore((tile.i, tile.j - 1));
        // look up
        MarkAsVisitedAndExplore((tile.i - 1, tile.j));
    }
}