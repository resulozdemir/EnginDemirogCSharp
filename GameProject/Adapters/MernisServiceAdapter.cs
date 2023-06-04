 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Abstract;

namespace ConsoleApp4.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.Name == "Resul")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
