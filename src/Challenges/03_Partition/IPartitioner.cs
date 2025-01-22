namespace Challenges._03_Partition;

public interface IPartitioner
{
    public abstract IEnumerable<ISet<Element>> Split(
        int count,
        IEnumerable<Element> input);
}