using AutoMapper;
using domain.DTO;
using domain.Entity;
using domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace domain.Service
{
    public class BaseService<TEntity> :IBaseService<TEntity> where TEntity : EntityBase
	{
		private readonly CustomerDBContext ctx;
        private DbSet<TEntity> Repository { get { return ctx.Set<TEntity>(); } }
        public BaseService(CustomerDBContext ctx)
        {
            this.ctx = ctx;
        }
        public BaseService(DbConnection conn)
        {
            ctx = new CustomerDBContext(conn);
        }
        public List<T> GetList<T>() where T : IDTO
        {
            return Repository.ToList().ConvertAll(o => Mapper.Map<T>(o));
        }
		public int Create<TDTO>(TDTO dto) where TDTO : IDTO
        {
            Repository.Add(Mapper.Map<TEntity>(dto));
			return ctx.SaveChanges();
		}
        public TDTO GetById<TDTO>(int id) where TDTO : class,IDTO
        {
            var entity= Repository.FirstOrDefault(o=>o.Id==id);
            if (entity != null)
            {
                return Mapper.Map<TDTO>(entity);
            }
            return null;
        }
        public int SaveOrUpdate<TDTO>(List<TDTO> Entities) where TDTO : class, IDTO
        {
            Entities.ForEach(entity => Repository.AddOrUpdate(Mapper.Map<TEntity>(entity)));
            return ctx.SaveChanges();
        }
        public int Delete<TDTO>(TDTO entity) where TDTO : class, IDTO
        {
            Repository.Remove(Mapper.Map<TEntity>(entity));
            return ctx.SaveChanges();
        }
        public List<TDTO> GetList<TDTO>(Expression<Func<TEntity, bool>> predicate) where TDTO : class, IDTO
        {
            return Repository.Where(predicate).ToList().ConvertAll(entity=> Mapper.Map<TDTO>(entity));
        }
	}
}
