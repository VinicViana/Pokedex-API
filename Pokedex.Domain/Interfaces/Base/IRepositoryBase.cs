using System;

namespace Pokedex.Domain.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        public void Cadastrar();
        public void Alterar(T entidade);
        public void Excluir(Guid IdeForExclusao);
        public void GetById(Guid IdForList);
        public void List();
    }
}
