using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeniorAppDB;
namespace SeniorAppNegocio
{
    public abstract class AbstractService<T>
    {
        protected SeniorAppDB.SeniorAppDB em = new SeniorAppDB.SeniorAppDB();
        public abstract void AddEntity(T entity);
        public abstract void UpdateEntity(T entity);
        public abstract void DeleteEntity(object key);
        public abstract T GetEntity(object key);
        public abstract List<T> GetEntities();
    }
}