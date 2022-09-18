using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.PokemonExceptions
{
    public class PokemonException : Exception
    {
        public PokemonException(string message) : base(message)
        {
        }
    }
}
