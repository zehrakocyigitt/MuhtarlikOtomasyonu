﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MuhtarlikOtomasyonu.Data.Contracts
{

    //CRUD İşlemleri Tek bir Class Üzerinden yapabilelim diye bu interfacei ekliyoruz.
    // Aksi takdirde her bir class için ayrı ayrı bu işlemleri tanımlamamız gerekir
    // Sadece newlenebilir yani sıradan classlar (abstract ve enumlar hariç) gelsin istediğimiz için aşağıdaki where kısıtını eklliyoruz.
   public interface IRepositoryBase <T> where T : class , new()
   {
       IQueryable<T> GetAll(Expression<Func<T,bool>> filter=null,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null ,string includeProperties = null);

       T Get(int id);

       T GetFirstOrDefault(Expression<Func<T,bool>> filter=null,string includeProperties = null);

       void Add(T entity);

       void Remove(T entity);

       void Update(T entity);
    }
}
