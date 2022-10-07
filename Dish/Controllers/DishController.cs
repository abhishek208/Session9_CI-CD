using Dish.Controllers.service;
using Dish.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dish.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {

        readonly IDishService _dishService;
        public DishController(IDishService dishService)
        {
            _dishService = dishService;

        }

        [HttpGet]
        public ActionResult GetAllDishes()
        {
               List<DishModel> dishes= _dishService.GetAllItems();
            return Ok(dishes);
        }

        [HttpGet]
        public ActionResult GetDishById(int id)
        {
            DishModel dish = _dishService.GetDishById(id);
            if (dish == null)
            {
                return NotFound();
            }
            
            return Ok(dish);
        }


    }
}
