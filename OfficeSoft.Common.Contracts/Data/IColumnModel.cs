using System;

namespace OfficeSoft.Data
{
    public interface IColumnModel
    {

        string DefaultValue { get; set; }

        bool Nullable { get; set; }
        bool IsPrimaryKey { get; set; }
        bool IsForeignKey { get; set; }
        Guid Id { get; set; }

        string Name { get; set; }
        DateTime? CreateDate { get; set; }

        IDataTypeModel GetDataType();
    }
}