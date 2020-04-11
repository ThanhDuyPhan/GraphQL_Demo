using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQL.Types
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Address);
        }
    }
}
