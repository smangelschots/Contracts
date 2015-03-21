using System;

namespace OfficeSoft.Data
{
    public interface IDataTypeModel
    {
        string Name { get; set; }
        int MaximumLength { get; set; }
        int NumericPrecision { get; set; }
        int NumericScale { get; set; }
        Type CSharpType { get; set; }
        string SqlDataType { get; set; }
    }
}