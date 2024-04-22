namespace LeetCodeChallenges;

public class IslandsBfsCounter : IslandsCounter
{
    private readonly Queue<(int i, int j)> _queue;

    private IslandsBfsCounter(string[,] map, bool debugOutput = false) : base(map, debugOutput)
    {
        _queue = new Queue<(int i, int j)>();
    }

    public static int CountIslands(string[,] map, bool debugOutput = false)
    {
        var counter = new IslandsBfsCounter(map, debugOutput);
        if (counter.DebugOutput) counter.PrintMap("Input map:");
        for (var i = 0; i < map.GetLength(0); i++)
        {
            for (var j = 0; j < map.GetLength(1); j++)
            {
                if (!counter.IsValidLandTile((i, j))) continue;
                counter.Count++;
                if (counter.DebugOutput)
                {
                    counter.Map[i, j] = "x";
                }
                else
                {
                    counter.Map[i, j] = "0";
                }

                counter._queue.Enqueue((i, j));
                while (counter._queue.Count > 0)
                {
                    var tile = counter._queue.Dequeue();
                    // look right
                    counter.MarkAndEnqueueIfLand((tile.i, tile.j + 1));
                    // look down
                    counter.MarkAndEnqueueIfLand((tile.i + 1, tile.j));
                    // look left
                    counter.MarkAndEnqueueIfLand((tile.i, tile.j - 1));
                    // look up
                    counter.MarkAndEnqueueIfLand((tile.i - 1, tile.j));
                }
            }
        }


        return counter.Count;
    }

    private void MarkAndEnqueueIfLand((int i, int j) tile)
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

        _queue.Enqueue(tile);
    }
}