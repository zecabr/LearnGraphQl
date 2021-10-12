using GraphQL.Types;
using GraphQlStudy.Contracts;
using GraphQlStudy.GraphQL.GraphQLType;

namespace GraphQlStudy.GraphQL.GraphQLQueries
{
	public class AppQuery : ObjectGraphType
	{
		public AppQuery(ICategoriaRepository repository)
		{
			Field<ListGraphType<CategoriaType>>("categorias", resolve: context => repository.GetAll());
		}
	}
}