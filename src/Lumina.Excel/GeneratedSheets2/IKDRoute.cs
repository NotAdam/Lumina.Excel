// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "IKDRoute", columnHash: 0x195ec33c )]
public partial class IKDRoute : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< IKDSpot >[] Spot { get; private set; }
    public uint Image { get; private set; }
    public uint Unknown7 { get; private set; }
    public uint Unknown8 { get; private set; }
    public LazyRow< TerritoryType > TerritoryType { get; private set; }
    public uint Unknown10 { get; private set; }
    public LazyRow< IKDTimeDefine >[] Time { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Spot = new LazyRow< IKDSpot >[3];
        for (int i = 0; i < 3; i++)
        	Spot[i] = new LazyRow< IKDSpot >( gameData, parser.ReadOffset< uint >( (ushort) ( 4 + i * 4 ) ), language );
        Image = parser.ReadOffset< uint >( 16 );
        Unknown7 = parser.ReadOffset< uint >( 20 );
        Unknown8 = parser.ReadOffset< uint >( 24 );
        TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< uint >( 28 ), language );
        Unknown10 = parser.ReadOffset< uint >( 32 );
        Time = new LazyRow< IKDTimeDefine >[3];
        for (int i = 0; i < 3; i++)
        	Time[i] = new LazyRow< IKDTimeDefine >( gameData, parser.ReadOffset< byte >( (ushort) ( 36 + i * 1 ) ), language );
        

    }
}