using GraphQlStudy.Entities;
using System.Collections.Generic;

namespace GraphQlStudy.Contracts
{
	public interface ICategoriaRepository
	{
		IEnumerable<Categoria> GetAll();
	}
}