using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructure
{
   public interface IRepositoryBase<T>where T:class //type de classe == type objet fortement typé
    {
         void Add(T entity);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> Condition); //expression type de l'expression lamda
        T GetById(string id);
        IEnumerable<T> GetMany(Expression<Func<T,bool>> Condition=null, //renvoie une liste enumérée
            Expression<Func<T, bool>> OrderBy=null);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> Condition);
        

    }
}
