[Serializable]
public class TimeMachineClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8373
{
	// Fields
	public TimeMachineBehaviour Repeat; // 0x18

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x1D17290 Offset: 0x1D17391 VA: 0x1D17290 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x1D172A0 Offset: 0x1D173A1 VA: 0x1D172A0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1D17340 Offset: 0x1D17441 VA: 0x1D17340
	public void .ctor() { }
}

