﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class ,new()
    {

        List<T> List();

        void Add(T p);

        void Delete(T p);

        void Update(T p);

        T GetById(int id);

        List<T> List(Expression<Func<T,bool>>filter);
    }
}
