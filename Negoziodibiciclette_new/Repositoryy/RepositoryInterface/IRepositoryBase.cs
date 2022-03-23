using Microsoft.EntityFrameworkCore;
using Models.Classi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositoryy.RepositoryInterface
{
  public interface IRepositoryBase<T> : IDisposable where T : class
    {






        DbSet<T> Table { get; }
        NegoziodibicicletteContext Context { get; }
        (string Schema, string TableName) TableSchemaAndName { get; }
        bool HasChanges { get; }

        //T FindAsNoTracking(TKey id);
        //T FindIgnoreQueryFilters(TKey id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, object>> orderBy);
        IQueryable<T> GetRange(IQueryable<T> query, int skip, int take);
        int Add(T entity, bool persist = true);
        int AddRange(IEnumerable<T> entities, bool persist = true);
        int BulkInsert(IList<T> entities, bool persist = true);
        int Update(T entity, bool persist = true);
        int UpdateRange(IEnumerable<T> entities, bool persist = true);
        int BulkUpdate(IList<T> entities, bool persist = true);
        int Delete(T entity, bool persist = true);
        int DeleteRange(IEnumerable<T> entities, bool persist = true);

        int BulkDelete(IList<T> entities, bool persist = true);
        int SaveChanges();




    }
}
