using System;
using System.Linq;
using System.Linq.Expressions;

namespace hsintongERP2022.Models
{
    public interface IDataObject<T>
    {    
        int ID { get; set; }
        IQueryable Take(Model_hsintong db, Expression<Func<T, bool>> expression, string orderCol, bool desc, int start, int length);
        int FilterCount(Model_hsintong db, Expression<Func<T, bool>> expression);
        //IQueryable Take(Model_legacy db, string keyword);
        int FilterCount(Model_hsintong db, string keyword);
        Expression<Func<T, bool>> StringPredicate(string keyword);
        int CountAll(Model_hsintong db);
        T GetOne(Model_hsintong db, int? id);
    }

}