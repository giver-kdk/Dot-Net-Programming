namespace _06_ORM_App.Repositories
{
    // Create an interface to create a standard for large project
    public interface IRepository<T>
    {
        public void AddRecord(T model);
        public IEnumerable<T> GetAllRecords(T model);
        public T GetSingleRecord(int id);
        public T UpdateRecord(T model);
        public T DeleteRecord(T model);
    }
}
