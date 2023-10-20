// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PreHandler", columnHash: 0xb3b4ab94 )]
public partial class PreHandler : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public uint Image { get; private set; }
    public ILazyRow Target { get; private set; }
    public LazyRow< Quest > UnlockQuest { get; private set; }
    public LazyRow< DefaultTalk > AcceptMessage { get; private set; }
    public LazyRow< DefaultTalk > DenyMessage { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Image = parser.ReadOffset< uint >( 4 );
        Target = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 8 ), language, "CollectablesShop", "InclusionShop", "GilShop", "SpecialShop", "Description" );
        UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 12 ), language );
        AcceptMessage = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 16 ), language );
        DenyMessage = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 20 ), language );
        Unknown1 = parser.ReadOffset< byte >( 24 );
        Unknown2 = parser.ReadOffset< byte >( 25 );
        

    }
}