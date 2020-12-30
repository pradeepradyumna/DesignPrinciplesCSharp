using System;

namespace InversionOfControl
{
    public class ControlOverFlow
    {
        /// <summary>
        /// Main() method controls the flow  of execution here
        /// If we introduce a GUI then the control will be handled by
        /// or taken care by that itself
        /// </summary>
        void main()
        {
            SomeExecution();
        }

        public void SomeExecution()
        {
            bool continuee = true;
            while (continuee)
            {

                DoTask1();
                DoTask2();

                continuee = ShouldContinue();
            }
        }

        private bool ShouldContinue()
        {
            throw new NotImplementedException();
        }

        private void DoTask2()
        {
            throw new NotImplementedException();
        }

        private void DoTask1()
        {
            throw new NotImplementedException();
        }
    }
}
