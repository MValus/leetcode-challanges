namespace Challenges._03_Partition;

public static class ElementUtils
{
    public static int SumOfPartition(ISet<Element> partition)
    {
        return partition.Sum(e => e.Sum);
    }
}