using System;

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
            string name = mDal.GetCustomerName(id);

            CapitalizeFirstCharacter(name);

            name = IncludeTitle(name);

            return name;
        }

        private string IncludeTitle(string name)
        {
            throw new NotImplementedException();
        }

        private void CapitalizeFirstCharacter(string name)
        {
            throw new NotImplementedException();
        }
    }
}
