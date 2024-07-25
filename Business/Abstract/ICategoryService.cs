using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService 
    {
        List<Category> GetAll();
        void Add(Category car);
        void Update(Category car);
        void Delete(Category car);

        
    }
}
