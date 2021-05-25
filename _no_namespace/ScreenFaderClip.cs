[Serializable]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 6083
{
	// Fields
	public ScreenFaderBehaviour template; // 0x18

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x2106100 Offset: 0x2106201 VA: 0x2106100 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x2106110 Offset: 0x2106211 VA: 0x2106110 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x21061B0 Offset: 0x21062B1 VA: 0x21061B0
	public void .ctor() { }
}

