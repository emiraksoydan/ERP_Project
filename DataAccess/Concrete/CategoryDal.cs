﻿using Core.EntityFramework;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : EfEntityFramework<Category,ConnectDB>,ICategoryDal
    {
    }
}
