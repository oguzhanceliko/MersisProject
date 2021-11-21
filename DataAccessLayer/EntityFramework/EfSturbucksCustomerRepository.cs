using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSturbucksCustomerRepository:GenericRepository<SturbucksCustomer>,ISturbucksCustomerDal
    {
    }
}
