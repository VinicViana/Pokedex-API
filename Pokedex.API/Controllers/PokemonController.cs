using Microsoft.AspNetCore.Mvc;
using Pokedex.Domain.Entities;
using Pokedex.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Pokedex.API.Controllers
{
    public class PokemonController
    {
        private readonly IPokemonRepository pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public List<Pokemon> ListAll()
        {
            return pokemonRepository.ListAll();
        }

        [HttpGet, Route("pokemon/{id}")]
        public ActionResult<Pokemon> Get(Guid Id)
        {
            return pokemonRepository.GetById(Id);
        }
    }
}
