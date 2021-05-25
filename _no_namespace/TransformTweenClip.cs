[Serializable]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 6096
{
	// Fields
	public TransformTweenBehaviour template; // 0x18
	public ExposedReference<Transform> startLocation; // 0x20
	public ExposedReference<Transform> endLocation; // 0x30

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x1D2C6F0 Offset: 0x1D2C7F1 VA: 0x1D2C6F0 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x1D2C700 Offset: 0x1D2C801 VA: 0x1D2C700 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1D2C850 Offset: 0x1D2C951 VA: 0x1D2C850
	public void .ctor() { }
}

