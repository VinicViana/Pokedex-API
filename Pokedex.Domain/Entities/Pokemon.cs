using Pokedex.Domain.Entities.Base;

namespace Pokedex.Domain.Entities
{
    public class Pokemon : Entity
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}
