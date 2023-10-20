// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EventIconType", columnHash: 0x6ce9409c )]
public partial class EventIconType : ExcelRow
{
    
    public uint NpcIconAvailable { get; private set; }
    public uint MapIconAvailable { get; private set; }
    public uint NpcIconInvalid { get; private set; }
    public uint MapIconInvalid { get; private set; }
    public byte IconRange { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NpcIconAvailable = parser.ReadOffset< uint >( 0 );
        MapIconAvailable = parser.ReadOffset< uint >( 4 );
        NpcIconInvalid = parser.ReadOffset< uint >( 8 );
        MapIconInvalid = parser.ReadOffset< uint >( 12 );
        IconRange = parser.ReadOffset< byte >( 16 );
        

    }
}