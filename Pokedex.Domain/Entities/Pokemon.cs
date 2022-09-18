using Pokedex.Domain.Entities.Base;
using Pokedex.Domain.PokemonExceptions;

namespace Pokedex.Domain.Entities
{
    public class Pokemon : Entity
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public Pokemon() : base() { }

        public void CadastrarPokemon()
        {
            isValid();
        }

        public void isValid()
        {
            if (Tipo.Equals("Planta"))
                throw new PokemonException("Não cadastramos pokemons tipo planta...");
        }
    }
}
