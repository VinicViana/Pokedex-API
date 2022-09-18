using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Entities;

namespace Pokedex.Infra
{
    public class PokedexContext : DbContext
    {
        public PokedexContext(DbContextOptions options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
