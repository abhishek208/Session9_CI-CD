using Dish.Controllers;
using Dish.Controllers.service;
using Dish.model;
using Microsoft.AspNetCore.Mvc;

namespace DishTest
{
    public class UnitTest1

    {

        readonly IDishService _dishService;
        readonly DishController _dishController;
        public UnitTest1( )
        {
            _dishService=new DishService();
            _dishController=new DishController(_dishService);
        }
        [Fact]
        public void Get_All_Dishes_Returns_OkResult()
        {
            // Act
            var okResult = _dishController.GetAllDishes();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        [Fact]
        public void Get_All_Test()
        {
            // Act
            var okResult = _dishController.GetAllDishes() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<DishModel>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
        
        [Fact]
        public void GetDishByID_Test()
        {
            // Arrange
            int id = 2;
            // Act
            var okResult = _dishController.GetDishById(id);
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void GetDishById_for_Non_Existing_Id_Test()
        {
            // Act
            var notFoundResult = _dishController.GetDishById(100);
            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult);
        }
    }
}