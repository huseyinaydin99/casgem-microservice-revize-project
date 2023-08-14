﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class, new()
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();
        T GetById(int id);
    }
}