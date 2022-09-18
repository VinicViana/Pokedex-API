using Pokedex.Domain.Entities;
using Pokedex.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.Infra.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokedexContext pokedexContext;

        public PokemonRepository(PokedexContext pokedexContext)
        {
            this.pokedexContext = pokedexContext;
        }

        public void Alterar(Pokemon entidade)
        {
            pokedexContext.Set<Pokemon>().Update(entidade);
        }

        public void Cadastrar(Pokemon entidade)
        {
            pokedexContext.Set<Pokemon>().Add(entidade);
        }

        public void Excluir(Guid Id)
        {
            Pokemon pokeToDelete = GetById(Id);
            pokedexContext.Set<Pokemon>().Remove(pokeToDelete);
        }

        public Pokemon GetById(Guid Id)
        {
            return pokedexContext.Set<Pokemon>().Where(i => i.Id.Equals(Id)).FirstOrDefault();
        }

        public List<Pokemon> ListAll()
        {
            return pokedexContext.Set<Pokemon>().ToList();
        }
    }
}
