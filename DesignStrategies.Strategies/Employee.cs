using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStrategies.Strategies
{
    public class Employee:EmployeeBase
    {
        public override bool IsTimeToPay(DateTime time)
        {
            return time>DateTime.Now;
        }

        public override void Pay()
        {
            // todo Pay
        }
    }
}
