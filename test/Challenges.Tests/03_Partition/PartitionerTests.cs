using Challenges._03_Partition;
using Shouldly;
using Xunit;

namespace Challenges.Tests._03_Partition;

public class PartitionerTests
{
    [Fact]
    public void TestGreedyPartitioner()
    {
        var input = new Element[]
        {
            new("0", 0)
        };

        var partitioner = new GreedyPartitioner();
        var partitions = partitioner.Split(2, input);
        var listOfPartitions = partitions.ToList();
        listOfPartitions.Count.ShouldBe(2);
        listOfPartitions.ShouldBe(new List<HashSet<Element>>
        {
            new() { new Element("0", 0) },
            new()
        });
    }

    [Fact]
    public void TestGreedyPartitionerSplitBy2()
    {
        var input = new Element[]
        {
            new("0", 3),
            new("1", 1),
            new("2", 1),
            new("3", 2),
            new("4", 2),
            new("5", 1)
        };

        var partitioner = new GreedyPartitioner();
        var partitions = partitioner.Split(2, input);
        var listOfPartitions = partitions.ToList();
        listOfPartitions.Count.ShouldBe(2);
        listOfPartitions.ShouldAllBe(partition => ElementUtils.SumOfPartition(partition) == 5);
    }

    [Fact]
    public void TestGreedyPartitionerSplitBy3()
    {
        var input = new Element[]
        {
            new("0", 3),
            new("1", 1),
            new("2", 1),
            new("3", 2),
            new("4", 2),
            new("5", 1)
        };

        var partitioner = new GreedyPartitioner();
        var partitions = partitioner.Split(3, input);
        var listOfPartitions = partitions.ToList();
        listOfPartitions.Count.ShouldBe(3);
        listOfPartitions.ShouldAllBe(partition => ElementUtils.SumOfPartition(partition) <= 4);
    }
}