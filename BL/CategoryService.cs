using DAL;
using DomainModel;
using ViewModel;

namespace BL
{
    public class CategoryService : ICategoryService
    {
        public void Add(CategoryInputModel model)
        {
            ///...            


            Category category = new Category
            {
                CategoryName = model.CategoryName,
                Description = model.Description,
                //...picture tabdil be byte
            };
            var repo = new GenericRepo();
            respo.Create(category);
        }
    }
}