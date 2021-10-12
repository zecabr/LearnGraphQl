using GraphQL.Types;
using GraphQlStudy.Entities;


namespace GraphQlStudy.GraphQL.GraphQLType
{
	public class CategoriaType : ObjectGraphType<Categoria>
	{
		public CategoriaType()
		{
			Field(x => x.CategoriaId, type: typeof(IdGraphType)).Description("Propriedeade categoriaId do objeto categoria.");
			Field(x => x.Nome).Description("Propriedeade nome do objeto categoria.");
			Field(x => x.ImagemUrl).Description("Propriedeade imagemUrl do objeto categoria.");


		}
	}
}