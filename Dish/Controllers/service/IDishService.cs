using Dish.model;

namespace Dish.Controllers.service
{
    public interface IDishService
    {
        public List<DishModel> GetAllItems();
        public DishModel GetDishById(int id);
    }
}
