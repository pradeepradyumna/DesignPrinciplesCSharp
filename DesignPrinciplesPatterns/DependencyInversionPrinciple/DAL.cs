using DependencyInversionPrinciple;

namespace Example
{
    class DAL : IDAL
    {
        public string GetCustomerName(int id)
        {
            return "SELECT statement to get NAME";
        }
    }
}
