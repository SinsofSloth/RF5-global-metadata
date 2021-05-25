[Serializable]
public class GrounderIKClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8349
{
	// Fields
	public GrounderIKBehavior template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F080 Offset: 0x16F181 VA: 0x16F080
	private GameObject <BindTarget>k__BackingField; // 0x20

	// Properties
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x1EB5D30 Offset: 0x1EB5E31 VA: 0x1EB5D30 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A70C0 Offset: 0x1A71C1 VA: 0x1A70C0
	// RVA: 0x1EB5D40 Offset: 0x1EB5E41 VA: 0x1EB5D40
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A70D0 Offset: 0x1A71D1 VA: 0x1A70D0
	// RVA: 0x1EB5D50 Offset: 0x1EB5E51 VA: 0x1EB5D50
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x1EB5D60 Offset: 0x1EB5E61 VA: 0x1EB5D60 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1EB5E70 Offset: 0x1EB5F71 VA: 0x1EB5E70
	public void .ctor() { }
}

