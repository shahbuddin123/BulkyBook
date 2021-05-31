using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BulkyBook.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<category>, IOrderHeaderRepository
    {

        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

        public void Add(OrderHeader entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderHeader> GetAll(Expression<Func<OrderHeader, bool>> filter = null, Func<IQueryable<OrderHeader>, IOrderedQueryable<OrderHeader>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public OrderHeader GetFirstOrDefault(Expression<Func<OrderHeader, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(OrderHeader entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<OrderHeader> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderHeader Obj)
        {
            _db.Update(Obj);
        }

        OrderHeader IRepository<OrderHeader>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
