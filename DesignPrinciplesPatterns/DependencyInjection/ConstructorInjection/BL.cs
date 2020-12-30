using DependencyInversionPrinciple;

namespace DependencyInjection.ConstructorInjection
{
    class BL
    {
        IDAL mDal;
        public BL(IDAL dal)
        {
            mDal = dal;
        }

        public string GetCustomerName(int id)
        {
            return mDal.GetCustomerName(id);
        }
    }
}
