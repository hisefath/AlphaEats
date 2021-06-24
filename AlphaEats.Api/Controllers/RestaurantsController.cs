﻿using AlphaEats.Api.Services;
using AlphaEats.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaEats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : Controller
    {
        public RestaurantsService _restaurantsService;

        public RestaurantsController(RestaurantsService restaurantsService)
        {
            _restaurantsService = restaurantsService;
        }

        [HttpGet("all-restaurants")]
        public IActionResult GetAllRestaurants()
        {
            var allRestaurants = _restaurantsService.GetAllRestaurants();
            return Ok(allRestaurants);
        }

        [HttpGet("restaurant-by-name")]
        public IActionResult GetRestaurantByName([FromQuery] string name)
        {
            var restaurant = _restaurantsService.GetRestaurantsByName(name);
            return Ok(restaurant);
        }

        [HttpPost("add-restaurant")]
        public IActionResult AddRestaurant([FromBody] Restaurant restaurant)
        {
            _restaurantsService.AddRestaurant(restaurant);
            return Ok();
        }

        [HttpPost("restaurant-search")]
        public IActionResult TopFiveRestaurantsFromSearch(string restaurantInput, string cuisineInput, int distanceInput, int ratingInput, int priceInput)
        {
            var restaurants = _restaurantsService.TopFiveRestaurantsFromSearch(restaurantInput, cuisineInput, distanceInput, ratingInput, priceInput);
            return Ok(restaurants);
        }

    }
}