using GraphQL.Types;
using GraphQLDemo.Models;
using GraphQLDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.GraphQL.Types
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType(ICustomerService customers)
        {
            Field(o => o.Id);
            Field(o => o.Name);
            Field<CustomerType>("customer",
                resolve: context => customers.GetCustomerByIdAsync(context.Source.CustomerId));
            Field<OrderStatusesEnum>("status",
                resolve: context => context.Source.Status);
        }
    }
}
