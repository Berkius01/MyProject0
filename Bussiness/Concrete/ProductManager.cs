﻿using Bussiness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        
        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }
        public List<Product> GetAll()
        {
            //iş kodları
            return _ProductDal.GetAll();
        }
    }
}
