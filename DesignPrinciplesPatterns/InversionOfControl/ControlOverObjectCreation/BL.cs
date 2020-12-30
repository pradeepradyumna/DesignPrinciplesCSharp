namespace Example
{
    class BL
    {
        private DAL mDal;
        public BL()
        {
            mDal = new DAL();
        }

        public string GetCustomerName(int id)
        {
            return mDal.GetCustomerName(id);
        }
    }
}
