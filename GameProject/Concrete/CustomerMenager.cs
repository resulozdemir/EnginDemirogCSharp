using ConsoleApp4.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Concrete
{
    public class CustomerMenager : ICustomerService
    {
        private ICustomerCheckService customerCheckService;

        public CustomerMenager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }


        public void Add(Customer customer)
        {
            if(customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Customer added.");
            }
            else
            {
                Console.WriteLine("Custemor could'nt added.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer Updated");
        }
    }
}
