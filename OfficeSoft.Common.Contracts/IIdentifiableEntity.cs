using System;

namespace OfficeSoft.Common.Contracts
{
    public interface IIdentifiableEntity
    {
        Guid EntityId { get; set; }
    }
}
