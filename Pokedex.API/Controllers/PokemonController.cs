using Microsoft.AspNetCore.Mvc;
using Pokedex.Domain.Entities;
using Pokedex.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pokedex.API.Controllers
{
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;
        }

        [HttpGet, Route("pokemon")]
        public List<Pokemon> ListAll()
        {
            return pokemonRepository.ListAll();
        }

        [HttpGet, Route("pokemon/{id}")]
        public ActionResult<Pokemon> Get(Guid id)
        {
            return pokemonRepository.GetById(id);
        }

        [HttpPost, Route("pokemon/create")]
        public ActionResult<Pokemon> PostPokemon([FromBody] Pokemon pokemon)
        {
            try
            {
                pokemon.CadastrarPokemon();
                return pokemonRepository.Cadastrar(pokemon);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
            
        }

        [HttpPut, Route("pokemon/update")]
        public ActionResult<Pokemon> PutPokemon([FromBody] Pokemon pokemon)
        {
            return pokemonRepository.Alterar(pokemon);
        }

        [HttpDelete, Route("pokemon/delete/{id}")]
        public void DeletePokemon(Guid id)
        {
            pokemonRepository.Excluir(id);
        }
    }
}
