// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Ornament", columnHash: 0x3d312c8f )]
public partial class Ornament : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public sbyte Adjective { get; private set; }
    public sbyte PossessivePronoun { get; private set; }
    public sbyte StartsWithVowel { get; private set; }
    public sbyte Unknown0 { get; private set; }
    public sbyte Pronoun { get; private set; }
    public sbyte Article { get; private set; }
    public ushort Model { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Icon { get; private set; }
    public ushort Transient { get; private set; }
    public short Order { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Adjective = parser.ReadOffset< sbyte >( 8 );
        PossessivePronoun = parser.ReadOffset< sbyte >( 9 );
        StartsWithVowel = parser.ReadOffset< sbyte >( 10 );
        Unknown0 = parser.ReadOffset< sbyte >( 11 );
        Pronoun = parser.ReadOffset< sbyte >( 12 );
        Article = parser.ReadOffset< sbyte >( 13 );
        Model = parser.ReadOffset< ushort >( 16 );
        Unknown1 = parser.ReadOffset< ushort >( 18 );
        Icon = parser.ReadOffset< ushort >( 20 );
        Transient = parser.ReadOffset< ushort >( 22 );
        Order = parser.ReadOffset< short >( 24 );
        Unknown2 = parser.ReadOffset< byte >( 26 );
        Unknown3 = parser.ReadOffset< byte >( 27 );
        Unknown4 = parser.ReadOffset< byte >( 28 );
        

    }
}