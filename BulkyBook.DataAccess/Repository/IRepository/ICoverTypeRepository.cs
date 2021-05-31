using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(category CoverType);
    }
}
