namespace Example.Revised
{
    class DAFactory
    {
        public static DAL GetDAObj()
        {
            return new DAL();
        }
    }
}
