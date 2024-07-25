using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void Add(Category car)
        {
           categoryDal.Add(car);
        }

        public void Delete(Category car)
        {
            categoryDal.Delete(car);
        }

        public List<Category> GetAll()
        {
           return  categoryDal.GetAll();
        }

  

        public void Update(Category car)
        {
            categoryDal.Update(car);
        }
    }
}
