using DependencyInversionPrinciple;
using Example.Revised;

namespace Example
{
    class BL
    {
        IDAL mDal;
        public BL()
        {
            IDAL mDal = DAFactory.GetDAObj();

        }
        public string GetCustomerName(int id)
        {
            return mDal.GetCustomerName(id);
        }
    }
}
