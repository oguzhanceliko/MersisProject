using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SturbucksCustomerManager : ISturbucksCustomerService
    {
        ISturbucksCustomerDal _sturbucksCustomerDal;

        public SturbucksCustomerManager (ISturbucksCustomerDal sturbucksCustomerDal)
        {
            _sturbucksCustomerDal = sturbucksCustomerDal;
        }

        public void TAdd(SturbucksCustomer t)
        {
            _sturbucksCustomerDal.Insert(t);
        }
    }
}
