using System;
using System.Collections.Generic;

namespace Pokedex.Domain.Interfaces.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        public void Cadastrar(T entidade);
        public void Alterar(T entidade);
        public void Excluir(Guid Id);
        public T GetById(Guid Id);
        public List<T> ListAll();
    }
}
