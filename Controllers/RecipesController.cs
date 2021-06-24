using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAPI.Models;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        //[HttpGet]
        //public string[] GetDishes()
        //{
        //    string[] dishes = { "Oxtail", "Curry Chicken", "Dumplings" };
        //    return dishes;
        //}

        [HttpGet]
        public ActionResult GetRecipes([FromQuery]int count)
        {

            Recipe[] recipes =
            {
                new (){Title="Oxtail"},
                new (){Title="Curry Chicken"},
                new (){Title="Dumplings"},
            };
            return Ok(recipes.Take(count));


        }

        //[HttpGet]
        //public ActionResult GetRecipes2([FromQuery]int count)
        //{
        //    string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings" };

        //    if (recipes.Any())
        //    {
        //        return NotFound();
        //    }

        //    return Ok(recipes.Take(count));

            
        //}

        [HttpPost]
        public ActionResult CreateNewRecipes([FromBody] Recipe newRecipe)
        {
            bool badThingsHappened = false;
            if (badThingsHappened)
                return BadRequest();

            return Created("",newRecipe);
        }


        [HttpDelete("{id}")]    //  /api/recipes/1323
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();
            return NoContent();

        }

    }
}
