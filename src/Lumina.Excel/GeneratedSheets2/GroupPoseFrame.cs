// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GroupPoseFrame", columnHash: 0x1771561e )]
public partial class GroupPoseFrame : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString GridText { get; private set; }
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Image { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        GridText = parser.ReadOffset< SeString >( 4 );
        Unknown0 = parser.ReadOffset< uint >( 8 );
        Unknown1 = parser.ReadOffset< int >( 12 );
        Image = parser.ReadOffset< int >( 16 );
        Unknown2 = parser.ReadOffset< int >( 20 );
        Unknown3 = parser.ReadOffset< int >( 24 );
        Unknown4 = parser.ReadOffset< byte >( 28 );
        

    }
}