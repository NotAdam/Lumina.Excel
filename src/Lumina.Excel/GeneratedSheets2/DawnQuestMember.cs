// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DawnQuestMember", columnHash: 0x9a909078 )]
public partial class DawnQuestMember : ExcelRow
{
    
    public LazyRow< ENpcResident > Member { get; private set; }
    public uint BigImageOld { get; private set; }
    public uint BigImageNew { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public LazyRow< DawnMemberUIParam > Class { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Member = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 0 ), language );
        BigImageOld = parser.ReadOffset< uint >( 4 );
        BigImageNew = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< ushort >( 12 );
        Unknown1 = parser.ReadOffset< byte >( 14 );
        Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadOffset< byte >( 15 ), language );
        

    }
}