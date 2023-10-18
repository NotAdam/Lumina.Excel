// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DawnContent", columnHash: 0x0300c94f )]
public partial class DawnContent : ExcelRow
{
    
    public LazyRow< ContentFinderCondition > Content { get; private set; }
    public uint ExpBelowExMaxLvl { get; private set; }
    public uint ExpAboveExMaxLvl { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown7 { get; private set; }
    public uint Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public uint Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Content = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< uint >( 0 ), language );
        ExpBelowExMaxLvl = parser.ReadOffset< uint >( 4 );
        ExpAboveExMaxLvl = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< uint >( 12 );
        Unknown1 = parser.ReadOffset< uint >( 16 );
        Unknown2 = parser.ReadOffset< uint >( 20 );
        Unknown3 = parser.ReadOffset< uint >( 24 );
        Unknown4 = parser.ReadOffset< uint >( 28 );
        Unknown5 = parser.ReadOffset< uint >( 32 );
        Unknown6 = parser.ReadOffset< uint >( 36 );
        Unknown7 = parser.ReadOffset< uint >( 40 );
        Unknown8 = parser.ReadOffset< uint >( 44 );
        Unknown9 = parser.ReadOffset< uint >( 48 );
        Unknown10 = parser.ReadOffset< uint >( 52 );
        Unknown11 = parser.ReadOffset< byte >( 56 );
        Unknown12 = parser.ReadOffset< bool >( 57 );
        Unknown13 = parser.ReadOffset< bool >( 57, 2 );
        Unknown14 = parser.ReadOffset< bool >( 57, 4 );
        

    }
}