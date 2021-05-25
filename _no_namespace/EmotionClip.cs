[Serializable]
public class EmotionClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8339
{
	// Fields
	[SerializeField] // RVA: 0x16EF00 Offset: 0x16F001 VA: 0x16EF00
	public EmotionType EmotionType; // 0x18
	[SerializeField] // RVA: 0x16EF10 Offset: 0x16F011 VA: 0x16EF10
	public Vector3 Offset; // 0x1C
	private EmotionBehavior EmotionBehavior; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x16EF20 Offset: 0x16F021 VA: 0x16EF20
	private GameObject <BindTarget>k__BackingField; // 0x30

	// Properties
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x2019710 Offset: 0x2019811 VA: 0x2019710 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F70 Offset: 0x1A7071 VA: 0x1A6F70
	// RVA: 0x2019720 Offset: 0x2019821 VA: 0x2019720
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F80 Offset: 0x1A7081 VA: 0x1A6F80
	// RVA: 0x2019730 Offset: 0x2019831 VA: 0x2019730
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x2019740 Offset: 0x2019841 VA: 0x2019740 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x2019870 Offset: 0x2019971 VA: 0x2019870
	public void .ctor() { }
}

