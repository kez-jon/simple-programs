namespace SimplePrograms.Interfaces
{
    public interface ITimesTable
    {
        string[] GetTable(int tableNo);
        string[] GetTable(int tableNo, int limit);
    }
}
