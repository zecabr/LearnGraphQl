using GraphQlStudy.Contracts;
using GraphQlStudy.Entities.Context;

namespace GraphQlStudy.Repository
{
	public class ProdutoRepository : IProdutoRepositry
	{
		private readonly AppDbContext _context;

		public ProdutoRepository(AppDbContext context)
		{
			_context = context;
		}
	}
}