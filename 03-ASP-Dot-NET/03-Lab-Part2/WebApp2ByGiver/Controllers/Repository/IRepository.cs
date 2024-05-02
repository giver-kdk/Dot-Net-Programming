namespace WebApp2ByGiver.Controllers.Repository
{
    public interface IRepository<T>
    {
        // 'GetAllRecords()' returns 'List<T>' because there is data fetch and needs to be returned
        public List<T> GetAllRecords();
    }
}
