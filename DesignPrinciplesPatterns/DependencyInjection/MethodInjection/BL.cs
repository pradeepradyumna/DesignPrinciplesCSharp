using DependencyInversionPrinciple;

namespace Example
{
    class BL
    {
        IDAL mDal;
        public void Initialize(IDAL dal)
        {
            mDal = dal;
        }

        public string GetCustomerName(int id)
        {
            return mDal.GetCustomerName(id);
        }
    }
}
