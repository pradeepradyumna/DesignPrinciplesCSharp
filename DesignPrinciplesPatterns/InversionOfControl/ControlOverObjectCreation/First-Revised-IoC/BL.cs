namespace Example.Revised
{
    /// <summary>
    /// We first got rid of the dependency of creating object by using new keyword and in constructor
    /// Thus, we have inverted the control of creating an object of a dependent class from the BL class to the DAFactory class.
    /// </summary>
    class BL
    {
        public string GetCustomerName(int id)
        {
            DAL mDal = DAFactory.GetDAObj();

            return mDal.GetCustomerName(id);
        }
    }
}
