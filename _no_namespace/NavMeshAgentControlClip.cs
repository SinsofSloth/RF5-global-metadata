[Serializable]
public class NavMeshAgentControlClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 6079
{
	// Fields
	public ExposedReference<Transform> destination; // 0x18
	[HideInInspector] // RVA: 0x15B660 Offset: 0x15B761 VA: 0x15B660
	public NavMeshAgentControlBehaviour template; // 0x28

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x1FB5630 Offset: 0x1FB5731 VA: 0x1FB5630 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x1FB5640 Offset: 0x1FB5741 VA: 0x1FB5640 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1FB5760 Offset: 0x1FB5861 VA: 0x1FB5760
	public void .ctor() { }
}

