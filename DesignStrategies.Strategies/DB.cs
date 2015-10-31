using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStrategies.Strategies
{
    public class DB
    {
        private static readonly EmployeeBase[] Storage = new[] {new Employee
        {
            Name ="Andrey"
        } };

        public static EmployeeBase GetEmployee(string name)
        {
            var e = Storage.FirstOrDefault(x => x.Name.ToLower().Equals(name.ToLower()));

            return e ?? EmployeeBase.NULL;
        }
    }
}
