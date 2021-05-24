[Serializable]
public class TimelineEventClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 10432
{
	// Fields
	public TimelineEventBehaviour template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1818C0 Offset: 0x1819C1 VA: 0x1818C0
	private GameObject <TrackTargetObject>k__BackingField; // 0x20

	// Properties
	public GameObject TrackTargetObject { get; set; }
	public ClipCaps clipCaps { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AF330 Offset: 0x1AF431 VA: 0x1AF330
	// RVA: 0x1C77330 Offset: 0x1C77431 VA: 0x1C77330
	public GameObject get_TrackTargetObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF340 Offset: 0x1AF441 VA: 0x1AF340
	// RVA: 0x1C77340 Offset: 0x1C77441 VA: 0x1C77340
	public void set_TrackTargetObject(GameObject value) { }

	// RVA: 0x1C77350 Offset: 0x1C77451 VA: 0x1C77350 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x1C77360 Offset: 0x1C77461 VA: 0x1C77360 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1C77440 Offset: 0x1C77541 VA: 0x1C77440
	public void .ctor() { }
}

