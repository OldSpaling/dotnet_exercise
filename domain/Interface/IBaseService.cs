using domain.DTO;
using domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interface
{
	public interface IBaseService<TEntity>:IDependence where TEntity : EntityBase
    {
        List<T> GetList<T>()where T:IDTO;
        int Create<T>(T entity) where T : IDTO;
        T GetById<T>(int id) where T : class, IDTO;
        int SaveOrUpdate<T>(List<T> Entities) where T : class, IDTO;
        int Delete<T>(T Entity) where T : class, IDTO;
        List<T> GetList<T>(Expression<Func<TEntity, bool>> predicate) where T : class, IDTO;
    }
}
