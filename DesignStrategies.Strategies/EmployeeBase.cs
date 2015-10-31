using System;

namespace DesignStrategies.Strategies
{
    public abstract class EmployeeBase
    {
        public abstract bool IsTimeToPay(DateTime time);
        public abstract void Pay();

        public string Name { get; set; }

        public static readonly EmployeeBase NULL = new NullEmployee();

        private class NullEmployee:EmployeeBase
        {
            public override bool IsTimeToPay(DateTime time)
            {
                return false;
            }

            public override void Pay()
            {
                //no stuff
            }
        }
    }
}
