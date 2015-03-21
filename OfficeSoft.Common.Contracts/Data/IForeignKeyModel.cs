using System;

namespace OfficeSoft.Data
{
    public interface IForeignKeyModel
    {
        string DeleteAction { get; set; }
        string UpdateAction { get; set; }
        string GetReferencedKey();
        string GetReferencedTable();
        Guid Id { get; set; }
        string Name { get; set; }
        DateTime? CreateDate { get; set; }
    }
}