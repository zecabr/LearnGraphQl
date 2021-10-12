using GraphQL;
using GraphQL.Types;
using GraphQlStudy.GraphQL.GraphQLQueries;

namespace GraphQlStudy.GraphQL.GraphQLScheme
{
	public class AppScheme : Schema
	{
		public AppScheme(IDependencyResolver resolver) : base(resolver)
		{
			Query = resolver.Resolve<AppQuery>();
		}
	}
}