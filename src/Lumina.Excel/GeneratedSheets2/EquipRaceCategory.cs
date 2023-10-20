// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EquipRaceCategory", columnHash: 0xf914b198 )]
public partial class EquipRaceCategory : ExcelRow
{
    
    public bool Hyur { get; private set; }
    public bool Elezen { get; private set; }
    public bool Lalafell { get; private set; }
    public bool Miqote { get; private set; }
    public bool Roegadyn { get; private set; }
    public bool AuRa { get; private set; }
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Male { get; private set; }
    public bool Female { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Hyur = parser.ReadOffset< bool >( 0 );
        Elezen = parser.ReadOffset< bool >( 1 );
        Lalafell = parser.ReadOffset< bool >( 2 );
        Miqote = parser.ReadOffset< bool >( 3 );
        Roegadyn = parser.ReadOffset< bool >( 4 );
        AuRa = parser.ReadOffset< bool >( 5 );
        Unknown0 = parser.ReadOffset< bool >( 6 );
        Unknown1 = parser.ReadOffset< bool >( 7 );
        Male = parser.ReadOffset< bool >( 8 );
        Female = parser.ReadOffset< bool >( 8, 2 );
        

    }
}