using EFCore.BulkExtensions;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Models.Classi;
using Repositoryy.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace Repositoryy.Repository
{
   public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {


        public DbSet<T> Table { get; }
        public NegoziodibicicletteContext Context { get; }

        private readonly bool _disposeContext;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        //  protected QuoteGeneratorRepositoryBase(IServiceScopeFactory serviceScopeFactory)
        protected RepositoryBase(NegoziodibicicletteContext context)
        {
            // _serviceScopeFactory = serviceScopeFactory;
            // using var scope = _serviceScopeFactory.CreateScope();
            Context = context;
            // Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //  Context = scope.ServiceProvider.GetRequiredService<QuoteGeneratorDbContext>(); ;

            Table = Context.Set<T>();


        }
        protected RepositoryBase(DbContextOptions<NegoziodibicicletteContext> options) : this(new NegoziodibicicletteContext(options))
        // protected QuoteGeneratorRepositoryBase(DbContextOptions<QuoteGeneratorDbContext> options, IServiceScopeFactory serviceScopeFactory) : this(serviceScopeFactory)
        {
            _disposeContext = true;
        }

        public virtual void Dispose()
        {
            if (_disposeContext)
            {
                Context.Dispose();
            }
        }

        public int SaveChanges()
        {
            try
            {

                return Context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
            {
                //A concurrency error occurred
                //Should log and handle intelligently
                //  throw new XmlDoganaGeneratorConcurrencyException("A concurrency error happened.", ex);
                throw new Exception("An error occurred updating the database", ex);
            }
            catch (System.Data.Entity.Infrastructure.RetryLimitExceededException ex)
            {
                //DbResiliency retry limit exceeded
                //Should log and handle intelligently
                //throw new XmlDoganaGeneratorRetryLimitExceededException("There is a problem with you connection.", ex);
                throw new Exception("An error occurred updating the database", ex);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                //Should log and handle intelligently
                if (ex.InnerException is SqlException sqlException)
                {
                    if (sqlException.Message.Contains("FOREIGN KEY constraint", StringComparison.OrdinalIgnoreCase))
                    {
                        //if (sqlException.Message.Contains("table \"Store.Products\", column 'Id'", StringComparison.OrdinalIgnoreCase))
                        //{
                        //    throw new QuoteGeneratorInvalidProductException($"Invalid Product Id\r\n{ex.Message}", ex);
                        //}
                        //if (sqlException.Message.Contains("table \"Store.Customers\", column 'Id'", StringComparison.OrdinalIgnoreCase))
                        //{
                        //    throw new QuoteGeneratorInvalidCustomerException($"Invalid Customer Id\r\n{ex.Message}", ex);
                        //}
                    }
                }
                throw new Exception("An error occurred updating the database", ex);
            }
            catch (Exception ex)
            {
                //Should log and handle intelligently
                //  throw new XmlDoganaGeneratorException("An error occurred updating the database", ex);
                throw new Exception("An error occurred updating the database", ex);
            }
        }

        public virtual int Add(T entity, bool persist = true)
        {
            Table.Add(entity);
            var ent = Context.Entry(entity);
            if (ent != null)
                Context.Entry(entity).State = EntityState.Added;
            var result = persist ? SaveChanges() : 0;
            if (ent != null)
                Context.Entry(entity).State = EntityState.Detached;
            return result;
        }



        private void added(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Context.Entry(entity).State = EntityState.Added;
            }
        }

        private void detach(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Context.Entry(entity).State = EntityState.Detached;
            }
        }

        private void modified(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Context.Entry(entity).State = EntityState.Modified;
            }
        }

        private void deleted(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Context.Entry(entity).State = EntityState.Deleted;
            }
        }
        public virtual int AddRange(IEnumerable<T> entities, bool persist = true)
        {
            added(entities);
            Table.AddRange(entities);
            var result = persist ? SaveChanges() : 0;
            detach(entities);


            return result;
        }


        public virtual int BulkInsert(IList<T> entities, bool persist = true)
        {
            added(entities);
            Context.BulkInsert<T>(entities);
            var result = persist ? SaveChanges() : 0;
            detach(entities);


            return result;
        }


        public virtual int Update(T entity, bool persist = true)
        {

            Table.Update(entity);
            Context.Entry(entity).State = EntityState.Modified;
            var result = persist ? SaveChanges() : 0;
            Context.Entry(entity).State = EntityState.Detached;
            return result;
        }

        public virtual int UpdateRange(IEnumerable<T> entities, bool persist = true)
        {

            modified(entities);
            Table.UpdateRange(entities);
            var result = persist ? SaveChanges() : 0;
            detach(entities);


            return result;
        }

        public virtual int BulkUpdate(IList<T> entities, bool persist = true)
        {
            modified(entities);
            Context.BulkUpdate(entities);
            var result = persist ? SaveChanges() : 0;
            detach(entities);

            return result;
        }


        public virtual int Delete(T entity, bool persist = true)
        {
            Table.Remove(entity);
            Context.Entry(entity).State = EntityState.Deleted;
            var result = persist ? SaveChanges() : 0;
            Context.Entry(entity).State = EntityState.Detached;
            return result;
        }

        public virtual int DeleteRange(IEnumerable<T> entities, bool persist = true)
        {
            deleted(entities);
            Table.RemoveRange(entities);
            var result = persist ? SaveChanges() : 0;
            detach(entities);


            return result;
        }

        public virtual int BulkDelete(IList<T> entities, bool persist = true)
        {


            deleted(entities);
            Context.BulkDelete<T>(entities);
            var result = persist ? SaveChanges() : 0;
            detach(entities);
            return result;
        }

        public virtual IQueryable<T> GetAll() => Table.AsNoTracking();  //.AsNoTracking();
        public virtual IQueryable<T> GetAll(Expression<Func<T, object>> orderBy) => Table.OrderBy(orderBy).AsNoTracking();
        public virtual IQueryable<T> GetRange(IQueryable<T> query, int skip, int take) => query.Skip(skip).Take(take).AsNoTracking();
        public bool HasChanges => Context.ChangeTracker.HasChanges();
        public (string Schema, string TableName) TableSchemaAndName
        {
            get
            {
                var metaData = Context.Model.FindEntityType(typeof(T).FullName);
                return (metaData.GetSchema(), metaData.GetTableName());
            }
        }
    }
}






  