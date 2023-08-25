using MVC_Kutuphane_Otomasyonu.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Repository
{
    public class GenericRepository<Tcontext, Tentity> : IGenericRepository<Tcontext, Tentity>
        where Tcontext : DbContext, new()
        where Tentity : class, new()
    {
        public void Delete(Tcontext context, Expression<Func<Tentity,bool>> filter)
        {
            var model = context.Set<Tentity>() FirstOrDefault(filter);
            context.Set<Tentity>().Remove(model);
        }

        private void FirstOrDefault(Expression<Func<Tentity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Tentity> GetAll(Tcontext context, Expression<Func<Tentity, bool>> filter = null)
        {

            return filter == null ? context.Set<Tentity>().ToList() : context.Set<Tentity>().Where(filter).ToList();
        }

        public Tentity GetByFilter(Tcontext context, Expression<Func<Tentity, bool>> filter)
        {
            return context.Set<Tentity>().FirstOrDefault(filter); 
        }

        public Tentity GetById(Tcontext context, int? id)
        {
            return context.Set<Tentity>().Find(id);
        }

        public void InsertorUpdate(Tcontext context, Tentity entity)
        {
            context.Set<Tentity>().AddOrUpdate(entity);
        }

        public void Save(Tcontext context)
        {
            context.SaveChanges();
        }
    }
}
