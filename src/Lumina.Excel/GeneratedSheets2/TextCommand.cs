// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TextCommand", columnHash: 0x5d4b4e4b )]
public partial class TextCommand : ExcelRow
{
    
    public SeString Description { get; private set; }
    public SeString Alias { get; private set; }
    public SeString ShortAlias { get; private set; }
    public SeString Command { get; private set; }
    public SeString ShortCommand { get; private set; }
    public uint Unknown11 { get; private set; }
    public LazyRow< TextCommandParam > Param { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Description = parser.ReadOffset< SeString >( 0 );
        Alias = parser.ReadOffset< SeString >( 4 );
        ShortAlias = parser.ReadOffset< SeString >( 8 );
        Command = parser.ReadOffset< SeString >( 12 );
        ShortCommand = parser.ReadOffset< SeString >( 16 );
        Unknown11 = parser.ReadOffset< uint >( 20 );
        Param = new LazyRow< TextCommandParam >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        Unknown0 = parser.ReadOffset< byte >( 26 );
        Unknown1 = parser.ReadOffset< byte >( 27 );
        Unknown2 = parser.ReadOffset< sbyte >( 28 );
        Unknown3 = parser.ReadOffset< sbyte >( 29 );
        Unknown4 = parser.ReadOffset< sbyte >( 30 );
        

    }
}