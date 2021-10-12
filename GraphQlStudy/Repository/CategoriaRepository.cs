using GraphQlStudy.Contracts;
using GraphQlStudy.Entities;
using GraphQlStudy.Entities.Context;
using System.Collections.Generic;
using System.Linq;

namespace GraphQlStudy.Repository
{
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly AppDbContext _context;

		public CategoriaRepository(AppDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Categoria> GetAll() => _context.Categorias.ToList();
		
	}
}