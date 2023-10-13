// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AchievementTarget", columnHash: 0x5bfa8a4e )]
public partial class AchievementTarget : ExcelRow
{
    
    public uint Value { get; private set; }
    public byte Type { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Value = parser.ReadOffset< uint >( 0 );
        Type = parser.ReadOffset< byte >( 4 );
        

    }
}