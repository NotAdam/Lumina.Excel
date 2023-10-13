using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.Generator.CodeGen;

public class BaseGenerator
{
    public Field Field { get; set; }
    public List<ExcelColumnDefinition> Columns { get; set; }
    public int StartColumnIndex { get; set; }
    public int StartOffset => _bitStartOffset / 8;

    protected int ColumnIndexOffset { get; set; }
    protected int OffsetOffset => _bitOffset / 8;

    private int _bitStartOffset;
    private int _bitOffset;
    
    protected BaseGenerator( Field field, List< ExcelColumnDefinition > columns, int startColumnIndex, int startOffset )
    {
        Field = field;
        Columns = columns;
        StartColumnIndex = startColumnIndex;
        _bitStartOffset = startOffset * 8;
    }

    public int ConsumedColumnCount() => Util.GetFieldCount(Field);

    public virtual void WriteFields( StringBuilder sb ) { }

    public virtual void WriteReaders( StringBuilder sb ) { }

    public virtual void WriteStructs( StringBuilder sb ) { }
    
    public virtual void WriteInitializers( StringBuilder sb ) { }

    public virtual List< string > EmitFields() { throw new NotImplementedException(); }
    
    public virtual List< string > EmitReaders() { throw new NotImplementedException(); }
    
    public virtual List< string > EmitStructs() { throw new NotImplementedException(); }
    
    public virtual List< string > EmitInitializers() { throw new NotImplementedException(); }

    protected string FieldName => Field.Name ?? $"Unknown{StartColumnIndex + ColumnIndexOffset}";
    
    protected int SizeOfCurrentColumn() => Util.SizeOf( Columns[ StartColumnIndex + ColumnIndexOffset ].Type );
    
    protected int SizeOfCurrentColumnBits() => Util.BitSizeOf( Columns[ StartColumnIndex + ColumnIndexOffset ].Type );
    
    protected string ClrTypeOfCurrentColumn() => Util.ExcelTypeToManaged( Columns[ StartColumnIndex + ColumnIndexOffset ].Type );

    protected string GetParserBitArg()
    {
        var thisType = Columns[ StartColumnIndex + ColumnIndexOffset ].Type;
        if( Util.IsBoolType( thisType ) )
        {
            var enumOffset = thisType - ExcelColumnDataType.PackedBool0;
            var flag = 1 << enumOffset;
            return $", {flag}";
        }
        else
        {
            return string.Empty;
        }
    }
    
    protected void SkipColumn(int count = 1)
    {
        for( int i = 0; i < count; i++ )
        {
            _bitStartOffset += SizeOfCurrentColumnBits();
            ColumnIndexOffset += 1;    
        }
    }
    
    protected int CurrentOffset() => StartOffset + OffsetOffset;

    protected void ResetOffsets()
    {
        ColumnIndexOffset = 0;
        _bitOffset = 0;
    }
}