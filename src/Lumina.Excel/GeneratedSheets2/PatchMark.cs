// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PatchMark", columnHash: 0x4b87e076 )]
public partial class PatchMark : ExcelRow
{
    
    public uint Unknown4 { get; private set; }
    public uint MarkID { get; private set; }
    public ushort SubCategory { get; private set; }
    public ushort Unknown7 { get; private set; }
    public byte SubCategoryType { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Version { get; private set; }
    public sbyte Category { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown4 = parser.ReadOffset< uint >( 0 );
        MarkID = parser.ReadOffset< uint >( 4 );
        SubCategory = parser.ReadOffset< ushort >( 8 );
        Unknown7 = parser.ReadOffset< ushort >( 10 );
        SubCategoryType = parser.ReadOffset< byte >( 12 );
        Unknown3 = parser.ReadOffset< byte >( 13 );
        Version = parser.ReadOffset< byte >( 14 );
        Category = parser.ReadOffset< sbyte >( 15 );
        

    }
}