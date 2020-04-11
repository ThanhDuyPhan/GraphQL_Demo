using GraphQL;
using GraphQL.Types;
using GraphQLDemo.GraphQL.Mutations;
using GraphQLDemo.GraphQL.Queries;

namespace GraphQLDemo.GraphQL
{
    public class GraphTestSchema : Schema
    {
        public GraphTestSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<GraphTestQuery>();
            Mutation = resolver.Resolve<GraphTestMutation>();
        }
    }
}
