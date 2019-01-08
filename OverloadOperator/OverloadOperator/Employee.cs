using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public override void SayName()
        {
            base.SayName();
            Console.WriteLine("ID: {0}", Id);
        }

        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                return true;
            else
                return false;
        }
        
        public static bool operator != (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
                return true;
            else
                return false;
        }
    }
}
