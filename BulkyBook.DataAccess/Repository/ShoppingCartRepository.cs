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
    public class ShoppingCartRepository : Repository<category>, IShoppingCartRepository
    {

        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db ): base(db)
        {
            _db = db;

        }

        public void Add(ShoppingCart entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShoppingCart> GetAll(Expression<Func<ShoppingCart, bool>> filter = null, Func<IQueryable<ShoppingCart>, IOrderedQueryable<ShoppingCart>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart GetFirstOrDefault(Expression<Func<ShoppingCart, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(ShoppingCart entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ShoppingCart> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ShoppingCart Obj)
        {
            _db.Update(Obj);
        }

        ShoppingCart IRepository<ShoppingCart>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
    }

