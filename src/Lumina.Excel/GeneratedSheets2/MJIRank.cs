// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIRank", columnHash: 0x929748f4 )]
public partial class MJIRank : ExcelRow
{
    
    public uint ExpToNext { get; private set; }
    public LazyRow< LogMessage >[] LogMessage { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpToNext = parser.ReadOffset< uint >( 0 );
        LogMessage = new LazyRow< LogMessage >[3];
        for (int i = 0; i < 3; i++)
        	LogMessage[i] = new LazyRow< LogMessage >( gameData, parser.ReadOffset< uint >( (ushort) ( 4 + i * 4 ) ), language );
        Unknown0 = parser.ReadOffset< byte >( 16 );
        

    }
}