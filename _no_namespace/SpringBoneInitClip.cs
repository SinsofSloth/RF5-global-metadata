[Serializable]
public class SpringBoneInitClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8366
{
	// Fields
	public SpringBoneInitBehavior template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F2A0 Offset: 0x16F3A1 VA: 0x16F2A0
	private GameObject <BindTarget>k__BackingField; // 0x20
	[SerializeField] // RVA: 0x16F2B0 Offset: 0x16F3B1 VA: 0x16F2B0
	private bool IsKeepInit; // 0x28

	// Properties
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x2248470 Offset: 0x2248571 VA: 0x2248470 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7300 Offset: 0x1A7401 VA: 0x1A7300
	// RVA: 0x2248480 Offset: 0x2248581 VA: 0x2248480
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7310 Offset: 0x1A7411 VA: 0x1A7310
	// RVA: 0x2248490 Offset: 0x2248591 VA: 0x2248490
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x22484A0 Offset: 0x22485A1 VA: 0x22484A0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x22485C0 Offset: 0x22486C1 VA: 0x22485C0
	public void .ctor() { }
}

