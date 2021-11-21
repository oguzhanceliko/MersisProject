namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
    }
}
