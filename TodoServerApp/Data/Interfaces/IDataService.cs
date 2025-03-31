namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        IEnumerable<TaskItem> GetTaskItem();
    }
}
