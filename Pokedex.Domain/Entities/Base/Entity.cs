using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Entities.Base
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }

        public Entity()
        {
            Id = new Guid();
            DataCadastro = DateTime.Now;
        }
    }
}
