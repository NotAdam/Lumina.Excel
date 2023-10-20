// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PvPRank", columnHash: 0xdbf43666 )]
public partial class PvPRank : ExcelRow
{
    
    public uint ExpRequired { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpRequired = parser.ReadOffset< uint >( 0 );
        

    }
}