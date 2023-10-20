// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CraftType", columnHash: 0xb92c9b70 )]
public partial class CraftType : ExcelRow
{
    
    public SeString Name { get; private set; }
    public byte MainPhysical { get; private set; }
    public byte SubPhysical { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        MainPhysical = parser.ReadOffset< byte >( 4 );
        SubPhysical = parser.ReadOffset< byte >( 5 );
        

    }
}