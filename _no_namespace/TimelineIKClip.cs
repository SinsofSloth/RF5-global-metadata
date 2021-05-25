[Serializable]
public class TimelineIKClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8379
{
	// Fields
	public TimelineIKBehaviour template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F330 Offset: 0x16F431 VA: 0x16F330
	private GameObject <TrackTargetObject>k__BackingField; // 0x20

	// Properties
	public GameObject TrackTargetObject { get; set; }
	public ClipCaps clipCaps { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A73B0 Offset: 0x1A74B1 VA: 0x1A73B0
	// RVA: 0x1D23650 Offset: 0x1D23751 VA: 0x1D23650
	public GameObject get_TrackTargetObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A73C0 Offset: 0x1A74C1 VA: 0x1A73C0
	// RVA: 0x1D23660 Offset: 0x1D23761 VA: 0x1D23660
	public void set_TrackTargetObject(GameObject value) { }

	// RVA: 0x1D23670 Offset: 0x1D23771 VA: 0x1D23670 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x1D23680 Offset: 0x1D23781 VA: 0x1D23680 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1D23760 Offset: 0x1D23861 VA: 0x1D23760
	public void .ctor() { }
}

