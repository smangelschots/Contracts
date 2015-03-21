using System;
using System.Collections.Generic;

namespace OfficeSoft.Data
{
    public interface ITableModel
    {
        List<IColumnModel> GetPrimaryKeys();
        Guid Id { get; set; }
        string Name { get; set; }
        DateTime? CreateDate { get; set; }
        List<IForeignKeyModel> GetForeignKeyModels();
    }
} 