﻿using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EntityLayer.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        readonly Context c;
        readonly DbSet<T> _object;

        public GenericRepository()
        {
            c = new Context();
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> expression)
        {
           return _object.Where(expression).ToList();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}