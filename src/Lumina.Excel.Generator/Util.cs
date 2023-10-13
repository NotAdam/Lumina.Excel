using System.Diagnostics;
using Lumina.Data.Structs.Excel;

namespace Lumina.Generator;

public static class Util
{
    public static string Clean( string str )
    {
        if( string.IsNullOrWhiteSpace( str ) )
            return null;

        str = str
            .Replace( "<", "" )
            .Replace( ">", "" )
            .Replace( "{", "" )
            .Replace( "}", "" )
            .Replace( "(", "" )
            .Replace( ")", "" )
            .Replace( "/", "" )
            .Replace( "[", "" )
            .Replace( "]", "" )
            .Replace( " ", "" )
            .Replace( "'", "" )
            .Replace( "-", "" )
            .Replace( "%", "Pct" );

        if( char.IsDigit( str[ 0 ] ) )
        {
            // kill me
            var index = str[ 0 ] - '0';
            var fucking = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            str = $"{fucking[ index ]}{str.Substring( 1 )}";
        }

        return str;
    }

    public static string ExcelTypeToManaged( ExcelColumnDataType type )
    {
        switch( type )
        {
            case ExcelColumnDataType.String:
                return "SeString";
            case ExcelColumnDataType.Bool:
                return "bool";
            case ExcelColumnDataType.Int8:
                return "sbyte";
            case ExcelColumnDataType.UInt8:
                return "byte";
            case ExcelColumnDataType.Int16:
                return "short";
            case ExcelColumnDataType.UInt16:
                return "ushort";
            case ExcelColumnDataType.Int32:
                return "int";
            case ExcelColumnDataType.UInt32:
                return "uint";
            case ExcelColumnDataType.Float32:
                return "float";
            case ExcelColumnDataType.Int64:
                return "long";
            case ExcelColumnDataType.UInt64:
                return "ulong";
            case ExcelColumnDataType.PackedBool0:
            case ExcelColumnDataType.PackedBool1:
            case ExcelColumnDataType.PackedBool2:
            case ExcelColumnDataType.PackedBool3:
            case ExcelColumnDataType.PackedBool4:
            case ExcelColumnDataType.PackedBool5:
            case ExcelColumnDataType.PackedBool6:
            case ExcelColumnDataType.PackedBool7:
                return "bool";
            default:
                throw new ArgumentOutOfRangeException( nameof( type ), type, null );
        }
    }
    
    public static int SizeOf( ExcelColumnDataType type )
    {
        switch( type )
        {
            case ExcelColumnDataType.String:
                return 4;
            case ExcelColumnDataType.Bool:
                return 1;
            case ExcelColumnDataType.Int8:
                return 1;
            case ExcelColumnDataType.UInt8:
                return 1;
            case ExcelColumnDataType.Int16:
                return 2;
            case ExcelColumnDataType.UInt16:
                return 2;
            case ExcelColumnDataType.Int32:
                return 4;
            case ExcelColumnDataType.UInt32:
                return 4;
            case ExcelColumnDataType.Float32:
                return 4;
            case ExcelColumnDataType.Int64:
                return 8;
            case ExcelColumnDataType.UInt64:
                return 8;
            default:
                throw new ArgumentOutOfRangeException( nameof( type ), type, null );
        }
    }
    
    public static int BitSizeOf( ExcelColumnDataType type )
    {
        switch( type )
        {
            case ExcelColumnDataType.String:
                return 32;
            case ExcelColumnDataType.Bool:
                return 8;
            case ExcelColumnDataType.Int8:
                return 8;
            case ExcelColumnDataType.UInt8:
                return 8;
            case ExcelColumnDataType.Int16:
                return 16;
            case ExcelColumnDataType.UInt16:
                return 16;
            case ExcelColumnDataType.Int32:
                return 32;
            case ExcelColumnDataType.UInt32:
                return 32;
            case ExcelColumnDataType.Float32:
                return 32;
            case ExcelColumnDataType.Int64:
                return 64;
            case ExcelColumnDataType.UInt64:
                return 64;
            case ExcelColumnDataType.PackedBool0:
            case ExcelColumnDataType.PackedBool1:
            case ExcelColumnDataType.PackedBool2:
            case ExcelColumnDataType.PackedBool3:
            case ExcelColumnDataType.PackedBool4:
            case ExcelColumnDataType.PackedBool5:
            case ExcelColumnDataType.PackedBool6:
            case ExcelColumnDataType.PackedBool7:
                return 1;
            default:
                throw new ArgumentOutOfRangeException( nameof( type ), type, null );
        }
    }
    
    public static int GetFieldCount(Field field)
    {
        if (field.Type == FieldType.Array)
        {
            var total = 0;
            if (field.Fields != null)
            {
                foreach (var nestedField in field.Fields)
                    total += GetFieldCount(nestedField);
            }
            else
            {
                total = 1;
            }
            return total * field.Count.Value;
        }
        return 1;
    }

    public static int GetFieldSize( Field field, List< ExcelColumnDefinition > columns, ref int columnStartIndex )
    {
        var baseOffset = columns[ columnStartIndex ].Offset;
        if (field.Name == "TodoParams")
            Debugger.Break();
        
        if( field.Type == FieldType.Array )
        {
            int skip = 0;
            foreach( var subField in field.Fields )
            {
                skip += GetFieldCount( subField );
            }
            return columns[ columnStartIndex + skip ].Offset - baseOffset;
        }
        
        return columns[ columnStartIndex + 1 ].Offset - baseOffset;
    }

    public static bool IsScalar( Field field )
    {
        return field.Type is FieldType.Scalar or FieldType.Color or FieldType.ModelId or FieldType.Icon;
    }

    public static bool IsSimpleArray( Field field )
    {
        // has no fields or single field is scalar
        return field is { Type: FieldType.Array, Fields: null } or { Type: FieldType.Array, Fields: [{ Type: FieldType.Icon or FieldType.Color or FieldType.ModelId }] };
    }

    public static bool IsSimpleLinkArray( Field field )
    {
        return field is { Type: FieldType.Array, Fields: [{ Type: FieldType.Link, Targets: not null }] };
    }

    public static bool IsComplexLinkArray( Field field )
    {
        return field is { Type: FieldType.Array, Fields: [{ Type: FieldType.Link, Targets: null }] };
    }

    public static bool DefinitionExists( string name )
    {
        return File.Exists( $"./Schemas_test/{name}.yml" );
    }
    
    public static int CalculateBitOffset(ExcelColumnDefinition def)
    {
        return CalculateBitOffset(def.Offset, def.Type);
    }
	
    public static int CalculateBitOffset(int offset, ExcelColumnDataType type)
    {
        var bitOffset = offset * 8;
        return type switch
        {
            ExcelColumnDataType.PackedBool0 => bitOffset + 0,
            ExcelColumnDataType.PackedBool1 => bitOffset + 1,
            ExcelColumnDataType.PackedBool2 => bitOffset + 2,
            ExcelColumnDataType.PackedBool3 => bitOffset + 3,
            ExcelColumnDataType.PackedBool4 => bitOffset + 4,
            ExcelColumnDataType.PackedBool5 => bitOffset + 5,
            ExcelColumnDataType.PackedBool6 => bitOffset + 6,
            ExcelColumnDataType.PackedBool7 => bitOffset + 7,
            _ => bitOffset,
        };	
    }

    public static bool IsBoolType( ExcelColumnDataType dataType )
    {
        return (int)dataType > (int)ExcelColumnDataType.PackedBool0;
    }

    public static bool IsBoolType( string dataTypeName )
    {
        return (int)Enum.Parse<ExcelColumnDataType>(dataTypeName) > (int)ExcelColumnDataType.PackedBool0;
    }
}