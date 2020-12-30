using DependencyInversionPrinciple;

namespace Example.Revised
{
    class DAFactory
    {
        public static IDAL GetDAObj()
        {
            return new DAL();
        }
    }
}
