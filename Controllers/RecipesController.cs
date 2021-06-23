using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public string[] GetDishes()
        {
            string[] dishes = { "Oxtail", "Curry Chicken", "Dumplings" };
            return dishes;
        }

        [HttpGet]
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings" };

            if (recipes.Any())
            {
                return NotFound();
            }

            return Ok(recipes);
        }


        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();
            return NoContent();

        }

    }
}
