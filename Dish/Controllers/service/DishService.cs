using Dish.model;

namespace Dish.Controllers.service
{
    public class DishService: IDishService
    {
        List<DishModel> dishes;
        public DishService()
        {
            dishes = new List<DishModel>()
            {
                new DishModel() { Id = 1, Name = "VadaPav" , Price=100 },
                 new DishModel() { Id = 2, Name = "Misal Pav" , Price=123 },
                  new DishModel() { Id = 3, Name = " Chicken Pav" , Price=103 },


            };
            }
        public List<DishModel> GetAllItems()
        {
            return dishes;
        }

        public DishModel GetDishById(int id)
        {
            return dishes.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
