// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingEmploymentNpcList", columnHash: 0x6195119b )]
public partial class HousingEmploymentNpcList : ExcelRow
{
    
    public LazyRow< ENpcBase > MaleENpcBase { get; private set; }
    public LazyRow< ENpcBase > FemaleENpcBase { get; private set; }
    public LazyRow< HousingEmploymentNpcRace > Race { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MaleENpcBase = new LazyRow< ENpcBase >( gameData, parser.ReadOffset< uint >( 0 ), language );
        FemaleENpcBase = new LazyRow< ENpcBase >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Race = new LazyRow< HousingEmploymentNpcRace >( gameData, parser.ReadOffset< byte >( 8 ), language );
        

    }
}