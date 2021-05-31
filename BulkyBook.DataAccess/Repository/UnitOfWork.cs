using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository
{
   public  class UnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {

            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);

        }

        public ICategoryRepository Category { get; private set; }

        public ICoverTypeRepository CoverType { get; private set; }
    }
}
