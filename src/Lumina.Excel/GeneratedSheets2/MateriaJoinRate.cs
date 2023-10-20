// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MateriaJoinRate", columnHash: 0xab31b42e )]
public partial class MateriaJoinRate : ExcelRow
{
    
    public float[] NQOvermeldPercentSlot { get; private set; }
    public float[] HQOvermeldPercentSlot { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NQOvermeldPercentSlot = new float[4];
        for (int i = 0; i < 4; i++)
        	NQOvermeldPercentSlot[i] = parser.ReadOffset< float >( 0 + i * 4 );
        HQOvermeldPercentSlot = new float[4];
        for (int i = 0; i < 4; i++)
        	HQOvermeldPercentSlot[i] = parser.ReadOffset< float >( 16 + i * 4 );
        

    }
}