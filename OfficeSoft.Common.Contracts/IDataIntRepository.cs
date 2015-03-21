using System;
using System.Collections.Generic;

namespace OfficeSoft.Common.Contracts
{
    public interface IDataIntRepository
    {

    }

    public interface IDataIntRepository<T> : IDataRepository
        where T : class, IIdentifiableIntEntity, new()
    {
        T Add(T entity);

        void Remove(T entity);
        
        void Remove(int id);

        T Update(T entity);

        IEnumerable<T> Get();

        T Get(int id);
    }
}
