﻿using System;
using System.Collections.Generic;

namespace OfficeSoft.Common.Contracts
{
    public interface IDataRepository
    {

    }

    public interface IDataRepository<T> : IDataRepository
        where T : class, IIdentifiableEntity, new()
    {
        T Add(T entity);

        void Remove(T entity);

        void Remove(Guid id);

        T Update(T entity);

        IEnumerable<T> Get();

        T Get(Guid id);
    }
}
