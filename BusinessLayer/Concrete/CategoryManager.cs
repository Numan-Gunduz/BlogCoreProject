﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryServices
	{
		ICategoryDal _categoryDal;

     

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}


		public List<Category> GetList()
		{
			return _categoryDal.GetListAll();
		}

        public Category GeyByID(int id)
		{
			return _categoryDal.GetByID(id);
		}

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);

        }

        public void TDelete(Category t)
        {
			_categoryDal.Delete(t);

        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);

        }
    }
}
