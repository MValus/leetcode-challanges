namespace Challenges._03_Partition;

public class GreedyPartitioner : IPartitioner
{
    public IEnumerable<ISet<Element>> Split(int count,
        IEnumerable<Element> input)
    {
        var sortedInput = input.OrderByDescending(x => x.Sum).ThenBy(x => x.Sum).ToList();
        var partitions = new List<HashSet<Element>>(count);
        for (var i = 0; i < count; i++)
        {
            partitions.Add([]);
        }

        foreach (var element in sortedInput)
        {
            var partition = FindPartitionWithLowestSum(partitions);
            partition.Add(element);
        }

        return partitions;
    }

    private static HashSet<Element> FindPartitionWithLowestSum(List<HashSet<Element>> partitions)
    {
        return partitions.MinBy(ElementUtils.SumOfPartition) ?? [];
    }
}