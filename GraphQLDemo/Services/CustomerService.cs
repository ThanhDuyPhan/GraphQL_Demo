using GraphQLDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<List<Customer>> GetCustomersAsync();
    }

    public class CustomerService : ICustomerService
    {
        List<Customer> _customers = new List<Customer>()
        {
            new Customer
            {
                Id = 1,
                Name = "Nguyen Van A",
                Address = "Vietnam"
            },
            new Customer
            {
                Id = 2,
                Name = "Tran Van B",
                Address = "Vietnam"
            },
            new Customer
            {
                Id = 3,
                Name = "Pham Thi C",
                Address = "Vietnam"
            },
        };

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(_customers.Single(o => Equals(o.Id, id)));
        }

        public Task<List<Customer>> GetCustomersAsync()
        {
            return Task.FromResult(_customers);
        }
    }
}
