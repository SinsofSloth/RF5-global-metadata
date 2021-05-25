[Serializable]
public class ConstraintClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8323
{
	// Fields
	public ConstraintBehavior template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16EDC0 Offset: 0x16EEC1 VA: 0x16EDC0
	private GameObject <BindTarget>k__BackingField; // 0x20

	// Properties
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x1FCA8D0 Offset: 0x1FCA9D1 VA: 0x1FCA8D0 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6DF0 Offset: 0x1A6EF1 VA: 0x1A6DF0
	// RVA: 0x1FCA8E0 Offset: 0x1FCA9E1 VA: 0x1FCA8E0
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6E00 Offset: 0x1A6F01 VA: 0x1A6E00
	// RVA: 0x1FCA8F0 Offset: 0x1FCA9F1 VA: 0x1FCA8F0
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x1FCA900 Offset: 0x1FCAA01 VA: 0x1FCA900 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1FCAA10 Offset: 0x1FCAB11 VA: 0x1FCAA10
	public void .ctor() { }
}

