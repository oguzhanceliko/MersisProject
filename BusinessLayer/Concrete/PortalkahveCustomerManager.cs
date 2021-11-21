using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PortalkahveCustomerManager : IPortalkahveCustomerService
    {
        IPortalkahveCustomerDal _portalkahveCustomerDal;

        

        public PortalkahveCustomerManager(IPortalkahveCustomerDal portalkahveCustomerDal)
        {
            _portalkahveCustomerDal = portalkahveCustomerDal;
        }


        public void TAdd(PortalkahveCustomer t)
        {
            _portalkahveCustomerDal.Insert(t);
        }
    }
}
