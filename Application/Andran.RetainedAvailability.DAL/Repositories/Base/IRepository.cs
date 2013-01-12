    using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Andran.RetainedAvailability.DAL.Repositories.Base
{
    public interface IRepository<T> : IDisposable where T : class
    {
        //IEnumerable<T> All();
        T GetById<T>(Guid id);

        //IEnumerable<T> Filter(Expression<Func<T, bool>>predicate);
        //bool Contains(Expression<Func<T, bool>> predicate);
        //T Create(T t);
        //void Delete(T t);
        //Guid Delete(Expression<Func<T,bool>> predicate);
        //Guid Update(T t);
        //int Count { get; }
    }
}
