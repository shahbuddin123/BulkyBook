﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
   public  interface ISP_Call
    {
        T Single<T>(String procedureName, DynamicParameters param = null);

        void Execute (String procedureName, DynamicParameters param = null);

        T OnRecord<T>(String procedureName, DynamicParameters param = null);

        IEnumerable<T> List <T>(String procedureName, DynamicParameters param = null);

        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1,T2>(String procedureName, DynamicParameters param = null);

    }
}
