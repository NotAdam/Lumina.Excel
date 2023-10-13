// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EventCustomIconType", columnHash: 0x9a111885 )]
public partial class EventCustomIconType : ExcelRow
{
    public struct IconsStruct
    {
    	public uint AnnounceQuest { get; internal set; }
    	public uint AnnounceQuestLocked { get; internal set; }
    	public uint MapAnnounceQuest1 { get; internal set; }
    	public uint MapAnnounceQuestLocked { get; internal set; }
    	public uint MapAnnounceQuest2 { get; internal set; }
    }
    
    public IconsStruct[] Icons { get; private set; }
    public byte Unknown50 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icons = new IconsStruct[10];
        for (int i = 0; i < 10; i++)
        {
        	Icons[i].AnnounceQuest = parser.ReadOffset< uint >( (ushort) (i * 20 + 0));
        	Icons[i].AnnounceQuestLocked = parser.ReadOffset< uint >( (ushort) (i * 20 + 4));
        	Icons[i].MapAnnounceQuest1 = parser.ReadOffset< uint >( (ushort) (i * 20 + 8));
        	Icons[i].MapAnnounceQuestLocked = parser.ReadOffset< uint >( (ushort) (i * 20 + 12));
        	Icons[i].MapAnnounceQuest2 = parser.ReadOffset< uint >( (ushort) (i * 20 + 16));
        }
        Unknown50 = parser.ReadOffset< byte >( 200 );
        

    }
}