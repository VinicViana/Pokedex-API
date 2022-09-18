using System;
using System.Collections.Generic;

namespace Pokedex.Domain.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        public T Cadastrar(T entidade);
        public T Alterar(T entidade);
        public void Excluir(Guid Id);
        public T GetById(Guid Id);
        public List<T> ListAll();
    }
}
