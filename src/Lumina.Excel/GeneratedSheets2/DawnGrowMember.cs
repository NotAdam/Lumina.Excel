// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DawnGrowMember", columnHash: 0xa0995e80 )]
public partial class DawnGrowMember : ExcelRow
{
    
    public uint[] SelectImage { get; private set; }
    public uint[] PortraitImage { get; private set; }
    public LazyRow< DawnMemberUIParam > Class { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SelectImage = new uint[3];
        for (int i = 0; i < 3; i++)
        	SelectImage[i] = parser.ReadOffset< uint >( 0 + i * 4 );
        PortraitImage = new uint[3];
        for (int i = 0; i < 3; i++)
        	PortraitImage[i] = parser.ReadOffset< uint >( 12 + i * 4 );
        Class = new LazyRow< DawnMemberUIParam >( gameData, parser.ReadOffset< byte >( 24 ), language );
        

    }
}